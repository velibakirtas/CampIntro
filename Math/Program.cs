namespace Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // iş yapan metot implamantasyonu
            FourTransactions fourTransactions = new FourTransactions();
            fourTransactions.Add(5, 6);



            // veri döndüren metot implamantasyonu
            Console.WriteLine(fourTransactions.Add2(5, 6));
            // metodun döndüreceği değeri konsolda yazdırdık

            // döndürülecek olan değeri bir değişkene atayalım
            int result = fourTransactions.Add2(5, 6);
            Console.WriteLine(result);



            // default parametreli metot implamantasyonu
            int sum = fourTransactions.Add3(5);
            Console.WriteLine(sum);
            // ikinci parametre default 30 olarak belirlendiği için 5+30 sonuncunu döndürür

            int sum2 = fourTransactions.Add3(5,6);
            Console.WriteLine(sum2);
            // Bu sefer ikinci parametre değeri gönderildiği için default 30 değeri kullanılmaz. Sonuç: 11

            // default değerler her zaman metot parametrelerinin en sonunda bulunmalıdır. Birden fazla parametre için default değer tanımlanabilir



            // ref keyword kullanarak ve kullanmadan implamantasyon
            int number1 = 10; // global scopeta number1 değişkenini tanımladık
            Console.WriteLine(fourTransactions.Add4(number1,10)); // metot içine parametre olarak gönderdik
            // sonuç: 40, çünkü metot içinde number1 değişkeni 30 olarak değiştirildi
            Console.WriteLine(number1); // fakat number1 değişkenini tekrar yazdırdığımızda 10 olarak döndüğünü görebiliriz

            Console.WriteLine(fourTransactions.Add5(ref number1, 10)); // metot içine parametre olarak gönderdik
            // sonuç: 40, çünkü metot içinde number1 değişkeni 30 olarak değiştirildi
            Console.WriteLine(number1); // bu sefer ref kullandığımız için her tek bir değişken ele alındı ve fonksiyonda değiştirilen değere eşit


            // out keyword implamantasyon
            int number2;
            Console.WriteLine(fourTransactions.Add6(out number2, 10)); 
            Console.WriteLine(number1);
            // out keyword de ref gibi çalışır iki farkla: ref bir değer atanmasını zorunlu kılarken out da bu zorunluluk yoktur
            // out ile yazıldığında değişken metot içinde mutlaka set edilmelidir


            // params implamantasyon
            int sumParams = fourTransactions.Add7(1,2,3,4,5,6,7,8,9);
            Console.WriteLine("toplam: " + sumParams);
        }
    }
}