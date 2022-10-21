using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(names[3]);

            /*
            names[4] = "İlker";
            Console.WriteLine(names[4]);
            */
            // Yukarıdaki kodu çalıştırdığımızda hata fırlatacaktır. Bunun sebebi: arrayler, sınırları belirli olan, genişletilemeyen veri tipleridir

            // COLLECTIONS
            List<string> names2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            // yukarıdaki anotasyonla istenilen tipte yeni bir collection oluşturulabilir

            Console.WriteLine(names2[3]);
            names2.Add("İlker");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);
            // görüldüğü gibi Add metoduyla names2 collectionına yeni bir eleman ekleyebiliriz
        }
    }
}