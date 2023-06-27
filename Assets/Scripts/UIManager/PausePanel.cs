using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Platformer.UIManager
{
    class PausePanel : MonoBehaviour, IPanel
    {
        [SerializeField] private Button restartButton;
        [SerializeField] private Button endGameButton;
        [SerializeField] private Button backButton;

        private void OnClickRestart()
        {
            
        }
        
        private void OnClickEndGame()
        {
            
        }
        
        private void OnClickBack()
        {
            
        }

        public void Construct(UIManager _uiManager)
        {
            throw new System.NotImplementedException();
        }

        public void Show()
        {
            throw new System.NotImplementedException();
        }

        public void Hide()
        {
            throw new System.NotImplementedException();
        }
    }
}