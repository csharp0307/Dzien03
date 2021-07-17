using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP.Pojazdy
{
    class Samochod : Pojazd
    {

        public Samochod(int liczbaDrzwi, int liczbaKol, int predkoscMax)
        {
            this.liczbaDrzwi = liczbaDrzwi;
            this.liczbaKol = liczbaKol;
            this.predkoscMax = predkoscMax;
            this.czySilnikowy = true;
        }

        public void Zatankuj()
        {
            Console.WriteLine("Pobierz LPG/PB/Diesel i zantankuj");
        }

    }
}
