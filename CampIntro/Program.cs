using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // c# type safety (tip güvenliği)nin ön planda olduğu bir dildir)
            string categorylabel = "Kategori";
            Console.WriteLine(categorylabel);

            int quantityStudent = 32000;
            double interestRate = 1.45;
            bool isLogged = false;

            if (isLogged == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

        }
    }
}