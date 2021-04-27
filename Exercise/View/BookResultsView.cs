using Exercise.Controller.Business.Interfaces;
using Exercise.Controller.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.View
{
    public class BookResultsView
    {
        public static void StartView()
        {
            bool isContinue = true;
            while (isContinue)
            {
                LaunchSearchStock();
                isContinue = AskContinue();
            }
        }

        private static void LaunchSearchStock()
        {
            string bookName = AskBookName();
            try
            {
                bool hasStock = HasStockBy(bookName);
                ShowStockInfo(hasStock);
            }
            catch (Exception ex)
            {
                ShowError();
            }
        }
        
        private static bool HasStockBy(string bookName)
        {
            return ServicesFactory<IBooksService>.GetInstance().HasStockBy(bookName);
        }

        private static void ShowStockInfo(bool hasStock)
        {
            if (hasStock)
            {
                ShowBookHasStock();
            }
            else 
            {
                ShowHasNoStock();
            }
        }

        private static void ShowBookHasStock()
        {
            ShowInfo("You are luck! Book is in stock!");
        }

        private static void ShowHasNoStock()
        {
            ShowInfo("Book is not in stock, please select another book!");
        }

        private static void ShowError()
        {
            ShowInfo("Sorry! System is not avaliable.");
        }

        private static void ShowInfo(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Press a key...");
            Console.ReadKey();
        }

        private static bool AskContinue()
        {
            ConsoleKeyInfo answer;
            bool? isContinue;
            do
            {
                Console.Write("¿Do you want to continue? (Y/N) : ");
                answer = Console.ReadKey();
                Console.WriteLine();
                if (answer.Key == ConsoleKey.Y) return true;
                if (answer.Key == ConsoleKey.N) return false;
                
            }
            while (true);
        }

        private static string AskBookName()
        {
            string bookName;
            Console.Write("BOOK NAME: ");
            bookName = Console.ReadLine();
            return bookName;
        }
    }
}
