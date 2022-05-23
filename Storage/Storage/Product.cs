using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    class Product 
    {
        public string Name { get; set; }
        public string Measure { get; set; }
        public int Cost { get; set; }
        public int Count { get; set; }
        public string LastDateDelivery { get; set; }

        public Product(string name, string measure, int cost, int count, string lastDateDelivery)
        {
            Name = name;
            Measure = measure;
            Cost = cost;
            Count = count;
            LastDateDelivery = lastDateDelivery;
        }
        public Product()
        {

        }
    }
}
