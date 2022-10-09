using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    // method class: metot classlar operasyon yani classa özel fonksiyonları tutan classlardır
    internal class BasketManager
    {
        public void Add(Product product) // BasketManager classının Add metodu Product classının bir objesini parametre olarak istemektedir
        {
            Console.WriteLine("Sepete eklendi: " + product.Name);
        }
    }
}
