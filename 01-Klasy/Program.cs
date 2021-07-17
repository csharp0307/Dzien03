using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Klasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod auto = new Samochod("Fiat", 220);
            auto.Predkosc = 200;
            auto.Predkosc = -200;
            auto.liczbaDrzwi = 5;
        }
    }
}
