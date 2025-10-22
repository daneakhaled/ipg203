using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StoreSystem.Models
{
    public class Food : Product
    {
        public DateTime ExpiryDate { get; set; }

        public Food(string id, string name, decimal price, DateTime expiryDate)
            : base(id, name, price)
        {
            ExpiryDate = expiryDate;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Food] {Name} - Expiry: {ExpiryDate.ToShortDateString()}, Price: {Price}$");
        }

        public override void Buy() => Console.WriteLine($"Buying Food: {Name}");
        public override void Return() => Console.WriteLine($"Returning Food: {Name}");
    }
}
