using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Controller.DI
{
    public static class ServicesFactory <T>
    {
        public static T GetInstance()
        {
            return DI.Kernel.DIProvider().Get<T>();
        }
    }
}
