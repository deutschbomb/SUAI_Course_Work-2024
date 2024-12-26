
namespace App
{
    public interface IView
    {
        void InitializeData(Presenter? presenter = null, MainForm? home = null);
    }
}
