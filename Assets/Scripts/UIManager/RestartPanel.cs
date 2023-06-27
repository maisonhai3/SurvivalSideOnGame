using UnityEngine;
using UnityEngine.UI;

namespace Platformer.UIManager
{
    class RestartPanel : MonoBehaviour, IPanel
    {
        [SerializeField] private Button restartButton;
        [SerializeField] private Button cancelButton;

        private void OnClickRestart()
        {
            
        }
        
        private void OnClickCancel()
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