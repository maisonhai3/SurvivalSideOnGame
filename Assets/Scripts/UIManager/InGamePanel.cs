using UnityEngine;
using UnityEngine.UI;

namespace Platformer.UIManager
{
    class InGamePanel : IPanel
    {
        [SerializeField] private Image heroHealthBar;

        private void OnHeroHealthChange()
        {
            
        }
    }
}