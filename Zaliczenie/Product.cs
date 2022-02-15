using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenie
{
    public class Product
    {
        public Product(string barcode, string name, decimal price)
        {
            Barcode = barcode;
            Name = name;
            NettoPrice = price;
        }

        public string Barcode { get; set; }
        public string Name { get; set; }
        public decimal NettoPrice { get; set; }

    }
}
