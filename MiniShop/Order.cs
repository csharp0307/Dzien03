using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    class Order
    {
        enum OrderStatus
        {
            NewOrder = 10,
            Complete = 20,
            Confirmed = 30,
            Shipped = 40,
            Delivered = 50,
            Returned = 60,
            Cancelled = 70
        }

        private String orderNumber = String.Empty;
        private int discount = 0;
        private String customerName;
        private String shipAddress;
        private DateTime orderDate;
        
        private List<OrderItem> items = new List<OrderItem>(); //utworzona pusta lista poz. zamówienia
        private OrderStatus status = OrderStatus.NewOrder;


        /// <summary>
        /// Szuka indeksu w pozycjach zamówienia dla danego produktu
        /// </summary>
        /// <param name="product">Obiekt produktu</param>
        /// <returns>-1 jeśli nie znaleziono, inaczej indeks na liscię poz. zamówienia</returns>
        private int GetProductIndex(Product product)
        {
            int result = -1;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ProductID == product.ID)
                    return i;
            }
            return result;
        }

        public bool AddProduct(Product product, int qnty)
        {
            if (!(product!=null && qnty>0 && status==OrderStatus.NewOrder))
                return false;

            //int productIndex = GetProductIndex(product);
            int productIndex = items.FindIndex(x => x.ProductID == product.ID);
            if (productIndex==-1)
            {
                items.Add(new OrderItem(product, qnty));
            } else
            {
                items[productIndex].UpdateQnty(qnty);
            }

            return true;
        }

        public bool RemoveProduct(Product product, int qnty=0)
        {
            if (!(product != null && qnty >= 0 && status == OrderStatus.NewOrder))
                return false;

            //int productIndex = GetProductIndex(product);
            int productIndex = items.FindIndex(x => x.ProductID == product.ID);
            if (productIndex == -1 || qnty > items[productIndex].Qnty)
                return false;

            if (qnty==0 || qnty== items[productIndex].Qnty)
            {
                items.RemoveAt(productIndex);
                return true;
            }

            items[productIndex].UpdateQnty(-qnty); // (-1)*qnty
            return true;

        }

        public bool Clear()
        {
            if (status==OrderStatus.NewOrder)
            {
                items.Clear();
                return true;
            }
            return false;
        }

        public void Print()
        {
            Console.WriteLine("Szczegóły zamówienia");
            foreach (var item in items)
            {
                Console.WriteLine("{0,-40}|{1,10}|{2,10:0.00}|{3,12:0.00}",
                    item.ProductName, item.Qnty, item.ProductPrice, item.ProductPrice*item.Qnty);
            }
            Console.WriteLine("Do zapłaty: {0}", CalcTotalAmount() );
        }

        public double CalcTotalAmount()
        {
            double total = 0;
            double totalQnty = 0;
            /*foreach (var item in items)
            {
                total += item.Qnty * item.ProductPrice; 
            }*/

            items.ForEach(item => { total += item.Qnty * item.ProductPrice; 
                totalQnty += item.Qnty;  });

            // zastosowanie dyskontu
            if (discount>0 && discount<100)
            {
                total *=  (100 - discount) / 100.0;
            }
            return total;
        }

    }
}
