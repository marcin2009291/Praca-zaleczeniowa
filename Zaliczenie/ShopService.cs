using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenie
{
    public class ShopService
    {
        public ShopService()
        {
            CreateProduct();
        }

        public static List<Product> Products { get; set; } = new List<Product>();
        private void CreateProduct()
        {
            Products.Add(new Product("101", "Masło extra", 6.50m));
            Products.Add(new Product("102", "Chleb wiejski", 4.50m));
            Products.Add(new Product("103", "Makaron Babuni", 9.20m));
            Products.Add(new Product("104", "Kiełbasa myśliwska", 29.0m));
            Products.Add(new Product("105", "Szynka konserwowa", 22.0m));
            Products.Add(new Product("106", "Chipsy paprykowe", 6.00m));
            Products.Add(new Product("107", "Serek wiejski", 3.50m));
            Products.Add(new Product("108", "Sól kuchenna", 2.70m));
            Products.Add(new Product("109", "Cukier kryształ", 3.20m));
            Products.Add(new Product("110", "Dżem truskawkowy", 8.10m));
        }

        public static void DisplayElements()
        {
            Console.WriteLine("**Lista produktów**");
            Console.WriteLine();
            Console.WriteLine("kod   | Cena net.|    Produkt");
            Console.WriteLine();

            foreach (Product element in Products)
            {
                Console.Write(element.Barcode);
                Console.Write("   |   ");
                Console.Write(element.NettoPrice);
                Console.Write("   |   ");
                Console.WriteLine(element.Name);  
               
            }

            Console.WriteLine();
        }
    }
}
