using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rules : IComparer<Product>
    {
        public int Compare(Product? a, Product? b)
        {
            if (a.Price > b.Price)
            {
                return 1;
            }
            if (a.Price == b.Price)
            {
                return 0;
            }
            return -1;
        }
    }
}
