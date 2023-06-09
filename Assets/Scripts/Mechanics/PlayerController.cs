﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platformer.Gameplay;
using static Platformer.Core.Simulation;
using Platformer.Model;
using Platformer.Core;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

namespace Platformer.Mechanics
{
    /// <summary>
    /// This is the main class used to implement control of the player.
    /// It is a superset of the AnimationController class, but is inlined to allow for any kind of customisation.
    /// </summary>
    public class PlayerController : KinematicObject
    {
        public AudioClip jumpAudio;
        public AudioClip respawnAudio;
        public AudioClip ouchAudio;

        /// <summary>
        /// Max horizontal speed of the player.
        /// </summary>
        public float maxSpeed = 7;
        
        /// <summary>
        /// Initial jump velocity at the start of a jump.
        /// </summary>
        public float jumpTakeOffSpeed = 7;
        
        public Health health;

        public JumpState jumpState = JumpState.Grounded;
        public enum JumpState
        {
            Grounded,
            PrepareToJump,
            Jumping,
            InFlight,
            Landed
        }

        private bool stopJump;

        public Collider2D collider2d;
        public AudioSource audioSource;
        private SpriteRenderer spriteRenderer;
        internal Animator animator;
        public PlayerInput playerInput;

        public bool controlEnabled = true;
        private bool jump;
        private Vector2 mMove;

        private readonly PlatformerModel model = Simulation.GetModel<PlatformerModel>();

        public Bounds Bounds => collider2d.bounds;

        void Awake()
        {
            health = GetComponent<Health>();
            audioSource = GetComponent<AudioSource>();
            collider2d = GetComponent<Collider2D>();
            spriteRenderer = GetComponent<SpriteRenderer>();
            animator = GetComponent<Animator>();
            // playerInput = GetComponent<PlayerInput>();
        }

        protected override void Update()
        {
            if (controlEnabled)
            {
                if (jumpState == JumpState.Grounded && Keyboard.current[Key.Space].wasPressedThisFrame)
                    jumpState = JumpState.PrepareToJump;
                else if (Keyboard.current[Key.Space].wasPressedThisFrame)
                {
                    stopJump = true;
                    Schedule<PlayerStopJump>().player = this;
                }
            }
            else
                mMove.x = 0;

            UpdateJumpState();
            
            base.Update();
        }
        
        public void OnMovement(InputAction.CallbackContext context)
        {
            mMove = context.ReadValue<Vector2>();
        }

        private void UpdateJumpState()
        {
            jump = false;
            switch (jumpState)
            {
                case JumpState.PrepareToJump:
                    jumpState = JumpState.Jumping;
                    jump = true;
                    stopJump = false;
                    break;
                case JumpState.Jumping:
                    if (!IsGrounded)
                    {
                        Schedule<PlayerJumped>().player = this;
                        jumpState = JumpState.InFlight;
                    }
                    break;
                case JumpState.InFlight:
                    if (IsGrounded)
                    {
                        Schedule<PlayerLanded>().player = this;
                        jumpState = JumpState.Landed;
                    }
                    break;
                case JumpState.Landed:
                    jumpState = JumpState.Grounded;
                    break;
            }
        }

        protected override void ComputeVelocity()
        {
            // Jump Controlling
            if (jump && IsGrounded)
            {
                velocity.y = jumpTakeOffSpeed * model.jumpModifier;
                jump = false;
            }
            else if (stopJump)
            {
                stopJump = false;
                if (velocity.y > 0)
                {
                    velocity.y = velocity.y * model.jumpDeceleration;
                }
            }

            targetVelocity = mMove * maxSpeed;
            
            // Animation Controlling
            if (mMove.x > 0.01f)
                spriteRenderer.flipX = false;
            else if (mMove.x < -0.01f)
                spriteRenderer.flipX = true;
            
            animator.SetBool("grounded", IsGrounded);
            animator.SetFloat("velocityX", Mathf.Abs(velocity.x) / maxSpeed);
        }
    }
}