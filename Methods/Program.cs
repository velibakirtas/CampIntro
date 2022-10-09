namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            // product classının bir instanceini oluşturduk
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Describe = "Amasya elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Describe = "Diyarbakır karpuzu";

            Product[] products = new Product[] { product1, product2 };
            // bir product array oluşturduk ve product1 ve product2 objelerini arraye koyduk

            foreach (Product product in products) // var keyword de kullanılabilir. var ilgili classı kendi bulup döngüyü çalıştırabilir
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Describe);
                Console.WriteLine("----------------");

            }

            Console.WriteLine("--------------Metotlar----------");
            BasketManager basketManager = new BasketManager();
            // BasketManager classından bir instance oluşturduk. (BasketManager bir operation classtı)
            basketManager.Add(product1);
            basketManager.Add(product2);
            // instance üzerinden metoda erişerek yukarıda oluşturduğumuz product objelerini sepete ekledik
        }

    }
}
// bir classtan üretilen tüm nesneler objecttir. Belirli spesifik nesne ise instancetir