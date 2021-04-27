using Exercise.Controller.Business.Interfaces;
using Exercise.Controller.DI;
using Exercise.View;
using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            InitializeDIKernel();
            BookResultsView.StartView();
        }
                
        private static void InitializeDIKernel()
        { 
            Controller.DI.Kernel.Load();
        }
    }
}
