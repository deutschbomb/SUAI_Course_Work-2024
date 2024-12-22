
namespace App
{
    public class Presenter : IPresenter
    {
        public IView View;
        public Context? Context;

        public Presenter(IView View)
        {
            this.View = View;
            this.Context = new Context();
            this.Context.Database.EnsureCreated();
        }

    }
}
