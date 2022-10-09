namespace ValueAndReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 30;
            number1 = number2;
            number2 = 65;
            // number1 değişkenine number2 yi atadığımıda ve number2 değişkenine yeni bir değer verdiğimizde number 1'in değeri kaç olur?
                /*  
                 * Cevap: 30
                 * Nedeni: 
                 *  Sayısal veri tipleri(int, float, double, decimal, bool) değer veri tipleridir
                 *  Bellekte stack ve heap olmak üzere alanlar bulunur. Değer veri tipleri stack alanında tutulur
                 *  stack alanında number1 = 10 olarak tanımlanır
                 *  number2 ise 30 olarak tanımlanır
                 *  daha sonra number2, number1 e atandığında aslında gerçekleşen şey number1 = number2'nin değeri
                 *  Yani sadece değer aktarılır ve number2 ile olan bütün irtibat kesilir
                 *  Dolayısıyla number2 yeniden tanımlandığında artık number1 ile de bağlantısı olmayacaktır
                 */
            Console.WriteLine(number1);

            int[] numbers1 = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 100, 200, 300 };
            numbers1 = numbers2;
            numbers2[0] = 999;
            // numbers1 array değişkenine numbers2 arrayini atadığımızda ve numbers2 arrayinin 0. elemanının değerini 999 yaptığımızda numbers1 arrayinin 0. elemanının değeri kaç olur?
            /*  
                 * Cevap: 999
                 * Nedeni:
                 *  array, class, interface gibi veri tipleri ise referans veri tipleridir
                 *  referans veri tiplerinde ise bir değişken oluşturulduğunda stackde değişken ismi heapte ise karşılığı tutulur
                 *  yani referans veri tiplerinde değer stackte bulunmaz 
                 *  stack ve heap arasındaki bağlantı da heap alanındaki karşılığın bir adresi (referansı) bulunur ve stackteki değişken bu adres bilgisini tutar
                 *  heap alanında tutulan verinin referansı stack alanındaki karşılığında tutulur.
                 *  Dolayısıyla numbers1=numbers2 dediğimizde yapıtğımız şey numbers1'in referans numarasını numbers2'nin referans numarasına eşitlemektir
                 *  Artık numbers1 de numbers 2 de başta numbers2 için tanımlanan verinin referans numarasını tutuyorlar
                 *  numbers2 arrayinin 0. elemanında yapılan değişiklik aslında referansta tutulan veride yapılan değişikliktir
                 *  number1 üzerinden 0. elemana ulaşmak istediğimizde aslında aynı referanstaki verinin 0. elemanına ulaşıyoruz 
                 *  
                 */
            Console.WriteLine(numbers1[0]);
        }
    }
}