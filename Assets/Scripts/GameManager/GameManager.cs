using System;
using UnityEngine;
using UnityEngine.Events;

namespace Platformer.GameManager
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;
        
        private EnemyGenerator enemyGenerator;
        private GameSummarizer gameSummarizer;
        private HardLevelController hardLevelController;

        public enum gameStates
        {
            START_PANEL,
            HERO_SELECT_PANEL,
            GAME_STARTED,
            GAME_PAUSE,
            GAME_OVER,
        }
        private gameStates currentGameState;
        
        public UnityAction StateChangedActions;

        private void SetCurrentGameState(gameStates toGameState)
        {
            currentGameState = toGameState;
            StateChangedActions();
        }

        private void Awake()
        {
            // Singleton
            if (Instance == null)
                Instance = this;
            else
                Destroy(this);
            
            Construct();
        }

        private void Construct()
        {
            enemyGenerator = GetComponentInChildren<EnemyGenerator>();
            gameSummarizer = GetComponentInChildren<GameSummarizer>();
            hardLevelController = GetComponentInChildren<HardLevelController>();
        }

        public void StartGame()
        {
            
        }

        public void EndGame()
        {
            throw new NotImplementedException();
        }

        public void RestartGame()
        {
            
        }

        public void CountEnemyKilled()
        {
            
        }
    }
}