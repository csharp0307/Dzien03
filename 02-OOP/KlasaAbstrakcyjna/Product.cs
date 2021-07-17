using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP.KlasaAbstrakcyjna
{
    class Product : AbstractProduct
    {
        public Product(String n, double p) : base(n, p)
        {

        }

        public override void ShowPrice()
        {
            Console.WriteLine("Cena={0}", price);
        }
    }
}
