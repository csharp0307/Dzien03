using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP.Pojazdy
{
    class SamochodElektryczny : Samochod 
    {
        private int pojemnoscBaterii;

        public SamochodElektryczny(int liczbaDrzwi, int liczbaKol, 
            int predkoscMax, int pojemnoscBaterii) : 
            base(liczbaDrzwi, liczbaKol, predkoscMax)
        {
            this.pojemnoscBaterii = pojemnoscBaterii;
            
        }

        public void Zatankuj()
        {
            Console.WriteLine("Podłącz do gniazdka");
        }
    }
}
