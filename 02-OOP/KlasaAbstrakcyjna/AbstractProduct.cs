using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP.KlasaAbstrakcyjna
{
    abstract class AbstractProduct
    {
        protected String name;
        protected double price;

        public AbstractProduct(String n, double p)
        {
            name = n; price = p;
        }

        public void ShowInfo()
        {
            Console.WriteLine("{0} - {1}", name, price);
        }

        // deklaracja metody bez jej implementacji
        public abstract void ShowPrice();
    }
}
