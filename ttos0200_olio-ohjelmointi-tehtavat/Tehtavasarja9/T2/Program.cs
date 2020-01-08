using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> tray = new List<Product>();
            tray.Add(new Product("Garlic", 1.50));
            tray.Add(new Product("Minced meat", 3.99));
            tray.Add(new Product("Crisps", 2.99));
            tray.Add(new Product("Cheddar sauce", 1.99));
            tray.Add(new Product("Bread", 2.49));
            tray.Add(new Product("Milk", 0.99));
            tray.Add(new Product("Milk", 0.99));
            tray.Add(new Product("Milk", 0.99));
            tray.Add(new Product("Cereal", 2.99));
            tray.Add(new Product("Frozen Pizza", 4.99));

            foreach (Product etc in tray)
            {
                Console.WriteLine("-Product : {0} {1} E", etc.Name, etc.Price);
            }
        }
    }
}
