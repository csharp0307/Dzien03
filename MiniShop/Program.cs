using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prRyz = new Product(1, "Ryż", 2.99, "Dobry, jasny...");
            Product prMaka = new Product(2, "Mąka", 3.49);
            Product prPapier = new Product(3, "Papier toaletowy", 12);

            Order order = new Order();

            order.AddProduct(prRyz, 0);

            order.AddProduct(prRyz, 1);
            order.AddProduct(prMaka, 2);
            order.AddProduct(prPapier, 3);

            order.AddProduct(prRyz, 2);
            order.AddProduct(prMaka, 3);
            order.AddProduct(prPapier, 4);

            order.Print();

            order.RemoveProduct(prPapier, 1);
            order.RemoveProduct(prMaka, 5);
            order.RemoveProduct(prRyz);



            //Console.WriteLine(order.CalcTotalAmount());
            Console.ReadKey();

        }
    }
}
