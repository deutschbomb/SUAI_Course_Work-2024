
namespace App
{
    public interface IViewPages : IView
    {
        DialogResult ResultDialog(string message, string head);
        void ErrorDialog(string message, string head);

        void Controls_toDefault();
        void Reset();
    }
}
