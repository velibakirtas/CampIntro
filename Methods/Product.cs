using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    // Property class oluşturalım: Property classlar property yani özellik tutan classlardır
    internal class Product
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Describe { get; set; }
    }
}
