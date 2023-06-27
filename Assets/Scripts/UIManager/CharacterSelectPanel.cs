using UnityEngine;
using UnityEngine.UI;

namespace Platformer.UIManager
{
    class CharacterSelectPanel : MonoBehaviour, IPanel
    {
        [SerializeField] private ToggleGroup heroToggleGroup;
        [SerializeField] private Button okButton;
        [SerializeField] private Button backButton;

        private void ChooseBlueHero()
        {
            
        }
        
        private void ChooseRedHero()
        {
            
        }

        private void OkButtonOnClick()
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