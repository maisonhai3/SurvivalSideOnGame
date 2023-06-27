using UnityEngine;
using UnityEngine.UI;

namespace Platformer.UIManager
{
    class InGamePanel : MonoBehaviour, IPanel
    {
        [SerializeField] private Image heroHealthBar;

        private void OnHeroHealthChange()
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