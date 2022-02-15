using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zaliczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Ekran.PokazPowitanie();
            
            ShopService test = new ShopService();
            Console.Clear();
            Ekran.Menu();
         
        }

      
    }
}

