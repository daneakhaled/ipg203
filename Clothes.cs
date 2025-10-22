using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem.Models
{
    public class Clothes : Product
    {
        public string Size { get; set; }

        public Clothes(string id, string name, decimal price, string size)
            : base(id, name, price)
        {
            Size = size;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Clothes] {Name} - Size: {Size}, Price: {Price}$");
        }

        public override void Buy() => Console.WriteLine($"Buying Clothes: {Name}");
        public override void Return() => Console.WriteLine($"Returning Clothes: {Name}");
    }
}
