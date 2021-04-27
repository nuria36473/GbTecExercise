using Exercise.Controller.Business.Interfaces;
using Exercise.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise.Controller.Business.Services
{
    class BooksService: IBooksService
    {
        private ContextBooks _context;

        public BooksService(ContextBooks context)
        {
            _context = context;
        }

        public bool HasStockBy(string title)
        {
            BookDetail book = _context.BookDetails.FirstOrDefault(x => x.bookname.ToUpper() == title.ToUpper());
            bool hasStock = book?.quantity > 0;
            return hasStock;
        }
    }
}
