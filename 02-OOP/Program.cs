using _02_OOP.KlasaAbstrakcyjna;
using _02_OOP.KlasaStatyczna;
using _02_OOP.Pojazdy;
using _02_OOP.Przeciazanie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //SamochodElektryczny samochod = null; // = new SamochodElektryczny(4, 4, 220, 500);
            //samochod.Zatankuj();
            //samochod.Uruchom();

            //Console.WriteLine(Utils.hostname);
            //Console.WriteLine(Utils.GetMaxValue(1,-1,10) );
            //Console.WriteLine(Utils.GetMaxValue(1,2) );
            //Console.WriteLine(Utils.GetMaxValue(1,2,3,4,5,6,7,8) );

            //Product product = new Product("Mleko", 2.99);
            //product.ShowPrice();

            Wektor w1 = new Wektor(2, 1);
            Wektor w2 = new Wektor(-3, 5);
            Wektor w3 = w1.Add(w2);            
            w3.Print();

            w3 = w1.Add(5);
            w3.Print();

            Wektor w4 = w1 + w2;
            w4.Print();

            w4 = w1 + 2;
            w4.Print();

            w4 = 2 + w1;
            w4.Print();

            Console.ReadKey();
        }
    }
}
