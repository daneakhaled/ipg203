using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem.Models
{
    public class Electronics : Product
    {
        public string Brand { get; set; }

        public Electronics(string id, string name, decimal price, string brand)
            : base(id, name, price)
        {
            Brand = brand;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Electronics] {Name} - Brand: {Brand}, Price: {Price}$");
        }

        public override void Buy() => Console.WriteLine($"Buying Electronics: {Name}");
        public override void Return() => Console.WriteLine($"Returning Electronics: {Name}");
    }
}
