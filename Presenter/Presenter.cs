
namespace App
{
    public class Presenter : IPresenter
    {
        public IView View;
        public Context? db;

        public Presenter(IView View)
        {
            this.View = View;
        }
    }
}
