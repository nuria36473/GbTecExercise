using Ninject.Modules;
using Ninject;
using Exercise.Controller.Business.Interfaces;
using Exercise.Controller.Business.Services;

namespace Exercise.Controller.DI
{
    public class Config : NinjectModule
    {
        public override void Load()
        {
            Bind<IBooksService>().To<BooksService>();
        }
    }
}
