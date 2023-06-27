namespace Platformer.UIManager
{
    public interface IPanel
    {
        public void Construct(UIManager _uiManager);

        public void Show();

        public void Hide();
    }
}