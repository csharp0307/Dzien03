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

            int productIndex = GetProductIndex(product);
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

            int productIndex = GetProductIndex(product);
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


        public double CalcTotalAmount()
        {
            double total = 0;
            foreach (var item in items)
            {
                total += item.Qnty * item.ProductPrice; 
            }

            // zastosowanie dyskontu
            if (discount>0 && discount<100)
            {
                total *=  (100 - discount) / 100.0;
            }
            return total;
        }

    }
}
