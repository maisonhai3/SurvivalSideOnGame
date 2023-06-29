using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Platformer.UIManager
{
    public class UIManager : MonoBehaviour
    {
        private GameManager.GameManager gameManager;
        
        private IPanel[] childPanels;

        private void Awake()
        {
            Construct();
        }

        private void Construct()
        {
            childPanels = GetComponentsInChildren<IPanel>();

            foreach (var panel in childPanels) 
                panel.Construct(this);

            gameManager = GameManager.GameManager.Instance;
            gameManager.StateChangedActions += OnGameStateChange;
        }

        private void OnGameStateChange()
        {
            
        }

        public void Sumarize()
        {
            
        }

        public void EndGameSumarize()
        {
            
        }
    }
}