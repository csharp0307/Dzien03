using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        private double rate; // stawka per godzina
        private double total = 0; // sumaryczna kwota do wypłaty 
        private List<double> hoursList;

        public Employee(string fname, string lname, double rate)
        {
            this.rate = rate;
            hoursList = new List<double>();
        }

        public void RegisterTime1(double hours)
        {
            hoursList.Add(hours);
        }

        private double CalcSalary()
        {
            double total = 0;
            foreach (var hours in hoursList)
            {
                if (hours <= 8)
                {
                    total += hours * rate;
                }
                else
                {
                    total += (8 * rate) + (hours - 8) * (rate * 2);
                }
            }
            return total;
        }

        public void RegisterTime(double hours)
        {
            if (hours<=8)
            {
                total += hours*rate;
            } else
            {
                total += (8 * rate) + (hours - 8) * (rate * 2);
                //total += (hours - 8) * (rate * 2);
            }
        }

        public void PaySalary()
        {
            Console.WriteLine("Do wypłaty: {0} PLN", total);
            total = 0;
        }

        public void PaySalary1()
        {
            Console.WriteLine("Do wypłaty: {0} PLN", CalcSalary() );
            hoursList.Clear();
        }

    }
}
