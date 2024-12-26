
namespace App
{
    public interface IViewDefault : IView
    {
        DialogResult ResultDialog(string message, string header);
        void ErrorDialog(string message, string header);

        void Controls_toDefault();
        void Return();
    }
}
