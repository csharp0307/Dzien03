using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP.Pojazdy
{
    class Pojazd : IPojazd, IPrzeglad
    {
        protected int liczbaKol;
        protected int liczbaDrzwi;
        protected int predkoscMax;
        protected bool czySilnikowy = false;

        public void Uruchom()
        {
            Console.WriteLine("Pojazd - Uruchom");
        }

        public void Zatankuj()
        {
            Console.WriteLine("Pojazd - Zatankuj");
        }

        public void Zatrzymaj()
        {
            Console.WriteLine("Pojazd - Zatrzymaj");
        }

        public void ZrobPrzeglad()
        {
            throw new NotImplementedException();
        }
    }
}
