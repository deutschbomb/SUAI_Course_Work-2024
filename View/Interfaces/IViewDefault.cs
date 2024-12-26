
namespace App
{
    public interface IViewDefault : IView
    {
        DialogResult ResultDialog(string message, string head);
        void ErrorDialog(string message, string head);

        void Controls_toDefault();
        void Return();
    }
}
