using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Klasy
{
    class Samochod
    {
        private String marka;
        private int predkoscMax;


        public int liczbaDrzwi;
        public int MyProperty { get; set; }

        // deklaracja właściwości / properties
        public int Predkosc
        {
            get { return predkoscMax; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Niepoprawna wartość");
                }
                else
                {
                    predkoscMax = value;
                }
            }
        }

        public Samochod(String marka, int predkosc)
        {
            this.marka = marka;
            predkoscMax = predkosc;
        }

        public int PodajPredkoscMax()
        {
            return predkoscMax;
        }

        public void UstaPredkoscMax(int nowaPredkoscMax)
        {
            predkoscMax = nowaPredkoscMax;
        }
    }
}
