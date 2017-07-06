using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _02.BookShop
{
    class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string title, string author, decimal price)
            : base(title, author, price)
        {
            
        }

        public override decimal Price
        {
            get { return decimal.Multiply(base.Price, 1.3m); }
        }
    }
}
