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
        }

        private void SetUpListener()
        {
            
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