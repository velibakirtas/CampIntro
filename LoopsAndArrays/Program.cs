using System;

namespace LoopsAndArrays;

class Program
{
    static void Main(string[] args)
    {
        // array 
        string[] courses = new string[] // string array
        {
            "Yazılım Geliştirici Yetiştirme Kampı",
            "Programlamaya Başlangıç İçin Temel Kurs",
            "Java"
        };

        // for loop
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(courses[i]);
        }

        for (int i = 0; i < 10; i++)
        // 1 den başlayarak ikinci terimdeki şart sağlandığı sürece devam eder
        // i++ birer birer artmasını sağlar
        {
            Console.WriteLine(i);
        }

        for (int i = 0; i < 10; i += 2)
        {
            Console.WriteLine(i);
        }

        // foreach loop
        foreach (string course in courses)
        {
            // iterable yapıların elemanlarını tek tek dönmek için kullanılır
            Console.WriteLine(course);
        }

        // while loop
        int j = 0;
        while (j <= 10)
        {
            Console.WriteLine("while ile yazıldı");
            j++;
        }
        // while döngüsünde döngü değişkeni bulunmaz. Bloğa girmeden başlangıçta değeri bilinen bir değişken kullanılır
        // condition kontrolü için kullanılan değişkenin değeri blok içinde değiştirilir 
    }
}