using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenie
{
    public class Zakupy
    {
        public static List<Product> Paragon { get; set; } = new List<Product>();
        public static void kod()
        {

            int p = 0;
            int w = 0;
            decimal netto = 0m;
            decimal brutto = 0m;
            DateTime teraz = DateTime.Now;
            
            while (w < 1)
            {
                Console.Clear();
                Console.WriteLine("PROSZĘ WYBRAĆ OPCJĘ");
                Console.WriteLine("1 => LISTA WSZYSTKICH PRODUKTÓW.");
                Console.WriteLine("2 => PODGLĄD PARAGONU");
                Console.WriteLine("3 => ZAKOŃCZ ZAKUPY");
                Console.WriteLine("");
                Console.WriteLine("101-110 => DODANIE POZYCJI DO LISTY ZAKUPÓW");
                p = int.Parse(Console.ReadLine());
                string k = p.ToString();
               
                
               
        
                if ((p > 100) && (p < 111))
                {
                    var wybor = ShopService.Products.Where(x => x.Barcode == k).ToList();

                    wybor.ForEach(x =>
                    {
                        Console.Clear();
                        Console.WriteLine("Produkt dodany do paragonu");
                        Console.WriteLine(" ");
                        Console.WriteLine(x.Name);
                        Paragon.Add(new Product(x.Barcode, x.Name, x.NettoPrice));
                        netto = netto + x.NettoPrice;
                    });
                    Console.WriteLine(" ");
                    Console.WriteLine("Naciśnij ENTER aby kontynuować ");
                    Console.ReadLine();
                    
                }
                else if (p == 1)
                {
                    Console.Clear();
                    ShopService.DisplayElements();

                    Console.WriteLine(" ");
                    Console.WriteLine("Naciśnij ENTER aby kontynuować ");
                    Console.ReadLine();
                }
                else if (p == 2)
                {
                    Console.WriteLine("**Lista zakupów**");
                    Console.WriteLine();
                    Console.WriteLine("Cena |    Produkt");
                    Console.WriteLine();

                    foreach (Product wypis in Paragon)
                    {
                        wypis.NettoPrice = wypis.NettoPrice * 1.23m;
                        wypis.NettoPrice = Math.Round(wypis.NettoPrice, 2);
                        Console.Write(wypis.NettoPrice);
                        Console.Write("   |   ");
                        Console.WriteLine(wypis.Name);

                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Naciśnij ENTER aby kontynuować ");
                    Console.ReadLine();
                }
                else if (p == 3)
                {
                    Console.Clear();
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("PARAGON");
                    Console.Write("Data zakupu:  ");
                    Console.WriteLine(teraz);
                    Console.WriteLine("----------------------------------------");
                    foreach (Product wypis in Paragon)
                    {
                        Console.Write("   " + wypis.NettoPrice);
                        Console.Write("   |   ");
                        Console.WriteLine(wypis.Name);
                    }
                    Console.WriteLine("----------------------------------------");
                    Console.Write("Do zapłaty:  ");
                    brutto = netto * 1.23m;
                    brutto = Math.Round(brutto, 2);
                    Console.WriteLine(brutto);
                    Console.Write("W tym vat:  ");
                    Console.WriteLine(brutto-netto);
                    Console.WriteLine("----------------------------------------");
                    Console.ReadLine();
                    Ekran.Koniec();
                    w = 2;
                    
                }
                else
                {
                    Console.WriteLine("Proszę podać poprawny numer");
                    Console.WriteLine(" ");
                    Console.WriteLine("Naciśnij ENTER aby kontynuować ");
                    Console.ReadLine();
                }
                
            }
            

        }

    }
}
