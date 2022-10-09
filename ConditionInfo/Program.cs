namespace ConditionInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           bool isLogged = false;

            if (isLogged == false)
            {
                Console.WriteLine("Lütfen giriş yapınız");
            }
            else
            {
                Console.WriteLine("Hoşgeldiniz");
            }


            // else if
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day");
            }
            else
            {
                Console.WriteLine("Good evening");
            }

                                                                // ternary operator

            /* syntax 
             * condition ? statement 1: statement 2
             */

            // şart bloklarının tek satırda yazılmasını sağlayan operatördür

            string userName = "";
            string password = "";

            Console.WriteLine("Kullanıcı Adı: ");
            userName = Console.ReadLine();
            Console.WriteLine("Parola: ");
            password = Console.ReadLine();

            // if-else sample
            if (userName == "admin" && password == "12345")
            {
                Console.WriteLine("Giriş Başarılı");
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya şifre hatalı");
            }

           string result = (userName == "admin" && password == "12345") ? "Giriş Başarılı" : "Kullanıcı Adı veya şifre hatalı";
            // eğer kullanıcı userName için "admin"; password için de "12345" bilgilerini girerse result değişkeninin değeri "Giriş Başarılı" stringi değilse "Kullanıcı Adı veya şifre hatalı" stringi olacaktır

            // ternary operatöründe birden fazla condition ve statement kullanılabilir. Yani else if yapısını da ternary ile kurabiliriz
            int x = 10, y = 100;
            string result2 = x > y ? "x is greater than y" :
                x < y ? "x is less than y" :
                x == y ? "x is equal to y" : "No result";


            // switch-case

            // program akışında verilen şlarta uygun değer olup olmadığını kontrol eder ve buna göre işlem yapar
            // Eğer uygun değer yoksa default durumunu aktif eder 
            /*
             * switch: koşulun kontrol edileceği değişken gönderilir
             * case: karşılaşılacak durumları tutar
             * break: döngüyü kırmak için kullanılır
             * default: durumlardan herhangi biri karşılanmıyorsa çalışır
             * */

            // kullanıcıdan alınacak sayıya karşılık gelen gün ismini veren bir switch-case bloğu oluşturalım
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int number = Int32.Parse(Console.ReadLine());
            switch (number)
            {
                case 1: Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
                default: 
                    Console.WriteLine("Böyle bir gün yok");
                    break;
            }
        }
    }
}