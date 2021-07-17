using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    /// <summary>
    /// Przechowuje informacje o pozycji zamówienia: produkt i liczba produktów
    /// </summary>
    class OrderItem
    {
        private Product product;
        private int qnty;

        public int ProductID { get { return product.ID; } }
        public double ProductPrice { get { return product.Price; } }
        public int Qnty { get { return qnty; } }

        public OrderItem(Product product, int qnty)
        {
            this.product = product;
            this.qnty = qnty;
        }

        public void UpdateQnty(int n)
        {
            qnty += n;
        }
    }
}
