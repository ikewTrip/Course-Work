using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class Product 
    {
        public string Name { get; set; }
        public string Measure { get; set; }
        public int Cost { get; set; }
        public int Count { get; set; }
        public string LastDateDelivery { get; set; }
    }
}