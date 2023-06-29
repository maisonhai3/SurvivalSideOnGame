using UnityEngine;
using UnityEngine.UI;

namespace Platformer.UIManager
{
    class StartPanel : MonoBehaviour, IPanel
    {
        private UIManager uiManager;
        
        [SerializeField] private Button startButton;

        private void Awake()
        {
            startButton.onClick.AddListener(OnClickStartGame);
        }
        
        private void OnClickStartGame()
        {
            
        }

        public void Construct(UIManager _uiManager)
        {
            uiManager = _uiManager;
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