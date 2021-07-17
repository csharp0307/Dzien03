using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    class Product
    {
        private int id;
        private string name;
        private double price;
        private string descr;
        private Boolean active = true;
        private Boolean promo = false;


        public int ID { get { return id; }  }
        public double Price { get { return price; }  }

        /// <summary>
        /// Konstruktor klasy Product
        /// </summary>
        /// <param name="id">ID produktu</param>
        /// <param name="name">Nazwa</param>
        /// <param name="price">Cena</param>
        /// <param name="descr">Opis</param>
        public Product(int id, string name, double price, string descr="")
        {
            this.id = id; this.name = name; this.price = price;
            this.descr = descr;
        }

        /// <summary>
        /// Aktualizuje cenę produktu
        /// </summary>
        /// <param name="newPrice">nowa cena produktu</param>
        public void ChangePrice(double newPrice)
        {
            price = newPrice;
        }

    }
}
