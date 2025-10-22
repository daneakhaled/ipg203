using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem.Models
{
    public abstract class Product : IBuyable
    {
        private string id; 
        public string Name { get; set; }
        public decimal Price { get; set; }

        public string Id
        {
            get { return id; }
            private set { id = value; }
        }

        public Product(string id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public abstract void DisplayInfo();
        public abstract void Buy();
        public abstract void Return();
    }
}
