using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenie
{
    public static class Ekran

    {
        public static void PokazPowitanie()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("WITAJ W PROGRAMIE KASY SKLEPOWEJ !!!!");
            Console.WriteLine("Naciśnij ENTER aby rozpocząć");
            Console.ReadLine();
        }
        public static void Koniec()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Prace wykonał: Hrabski Marcin");
            Console.WriteLine("Numer albumu: 110945");
            Console.WriteLine("Informatyka niestacjonarna, grupa 2");
            Console.ReadLine();
        }
        public static void Menu()
        {
            int a;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("PROSZĘ WYBRAĆ OPCJĘ");
            Console.WriteLine("1 => LISTA WSZYSTKICH PRODUKTÓW.");
            Console.WriteLine("2 => ZAKUPY");
            Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
            a = int.Parse(Console.ReadLine());
            Console.Clear();

            if (a == 1)
            {
                Console.Clear();
                ShopService.DisplayElements();
                
                Ekran.Menu();
            }
            else if (a == 2)
            {
                Console.Clear();
                Zakupy.kod();
            }
            else
            {
                Ekran.Koniec();
            }
        }
    }
}
