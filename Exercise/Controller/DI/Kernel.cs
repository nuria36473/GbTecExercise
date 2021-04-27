using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Controller.DI
{
    public static class Kernel
    {
        private static StandardKernel kernel = new StandardKernel();

        public static void Load()
        {
            kernel.Load(Assembly.GetExecutingAssembly());
        }

        public static StandardKernel DIProvider()
        {
            return kernel;
        }
    }
}
