using UnityEngine;
using UnityEngine.UI;

namespace Platformer.UIManager
{
    class GameOverPanel : MonoBehaviour , IPanel
    {
        [SerializeField] private Button okButton;

        private void OnClickBackToChooseHero()
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