using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Controller.Business.Interfaces
{
    interface IBooksService
    {
        bool HasStockBy(string title);
    }
}
