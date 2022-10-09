using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    internal class FourTransactions
    {
        // iş (operasyon) yapan metotlar
        public void Add(int number1, int number2) 
        {
            int sum = number1 + number2;
            Console.WriteLine("Sonuç: " + sum);
        }
        // bu metot bir operasyon metodudur. Bir işlem dizisi gerçekleştirir. İş yapan metotlar void kw ile oluşturulur
        // metotlar içerisinde yapılan işlemlerden sonra bir veri de döndürebilir


        // veri döndüren metotlar
        public int Add2(int number1, int number2)
        {
            return number1 + number2;
            /* var kw ile geçici değişkene de atanabilirdi 
             *  `var result = number1 + number2;`
             *  `return result;`
             */  
        }
        // veri döndüren metotlarda döndürülecek veri return ile döndürülür
        // metodun döndüreceği veri tipi ne ise o veri tipiyle oluşturulur. Kendi classlarımızı da kullanabiliriz


        // default parametreli metotlar
        public int Add3(int number1, int number2 = 30) // metotta istenen ikinci parametreyi default olarak belirledik
        // eğer metot kullanılırken ikinci parametre değeri girilmezse ikinci parametre default 30 olarak alınacaktır
        {
            var result = number1 + number2;
            return result;
        }



        // ref keyword

        /* ref keyword local scopetaki değişkendeki değişimin global scopte da geçerli olmasını sağlamak için kullanılır
         * değer veri tipleri sadece değer temelli çalışması nedeniyle fonksiyonlar içinde belirlenen değeri kullanır ve fonksiyon görevi bittikten sonra global scopetaki değeri hala geçerli olur. Scope ile ilgili detaylı bilgi edinilebilir
         * Yani global scopeta bulunan bir değer veri tutan değişken fonksiyon içinde farklı bir değer veriye sahip olur ve bu değer değişimi global scopetaki değeri etkilemez.
         * Özetlenecek olursa her iki scope içinde bellekte iki farklı değişken tanımlanmış olur
         * Biz yazdığmız fonksiyondaki değerin globaldeki değişkeni etkilemesini isteyebiliriz. ref kw bu yüzden kullanılır
         * ref kw bellekte iki farklı değişken tanımlanmasını engelleyerek globalde tanımlanan değişkeni her iki scopeta da tek değişken olarak kullanır
         */
        public int Add4(int number1, int number2) 
        {
            number1 = 30;
            var result = number1 + number2;
            return result;
        }

        public int Add5(ref int number1, int number2)
        {
            number1 = 30;
            var result = number1 + number2;
            return result;
        }


        // out keyword 
        public int Add6(out int number1, int number2)
        {
            number1 = 30;
            var result = number1 + number2;
            return result;
        }
        // out keyword de ref gibi çalışır iki farkla: ref bir değer atanmasını zorunlu kılarken out da bu zorunluluk yoktur
        // out ile yazıldığında değişken metot içinde mutlaka set edilmelidir



        // method overloading
        public int Multiply(int number1, int number2) 
        {
            return number1 * number2;
        }

        public int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2* number3;
        }
        // metotlarda signaturelar (imzalar) farklı olduğu sürece aynı metot oluşturulabilir
        // yukarıdkai metotların ilkinnin imzasında 2 parametre bulunurken, ikincinin imzasında 3 parametre bulunur. Dolayısıyla method overloading gerçekleşir



        // params keyword
        public int Add7(params int[] numbers)
        {
            var result = numbers.Sum(); // int arraylerin metotlarında olan Sum metoduyla arrayin içindeki değerlerin toplamını aldık
            return result;
        }
        // params keywordü fonksiyonlara atanacak parametre sayısı belli olmadığında kullanılır
        // implamantasyoda gönderilen parametreleri bir array içinde tutar. Dolayısıyla iterator bir yapı söz konusudur
        // params parametreler de parametrelerin sonunda belirtilmelidir
    }
}
