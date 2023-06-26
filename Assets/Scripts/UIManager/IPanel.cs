namespace Platformer.UIManager
{
    internal interface IPanel
    {
        public void SetUp(UIManager uiManager) { }

        public void Show() { }
        
        public void Hide() { }
    }
}