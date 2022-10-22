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


            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";
            // 2 tane Person objesi oluşturduk ve person1 objesinin FirstName propertysini "Engin" olarak düzenledik
            person2 = person1;
            // daha sonra person2 ye person1 objesini gönderdik
            // burada oluşacak şey: person1'in önceki tuttuğu referans adresi artık person2'nin tuttuğu referans adresine eşitlendi
            person1.FirstName = "Veli";
            // daha sonra person1 objesinin FirstName propertysinin set ettik
            // person2 objesinin referans numarası person1'e eşit olduğu için person2'den propertylere eriştiğimizde aynı propertyler dönecektir
            // her iki objeden yapılan değişiklik her iki obje içinde geçerlidir. Çünkü aynı referans adresini tutmaktadırlar
            Console.WriteLine(person2.FirstName);


            Customer customer1 = new Customer();
            customer1.FirstName = "Mehmet";
            customer1.CreditCardNumber = "123456789";
            Employee employee1 = new Employee();

            Person person3 = customer1;
            // normalde iki farklı tipteki veri birbirine atanamaz. Yani int bir değişkene string bir veri gönderilemez
            // fakat biz burada Person tipindeki bir değişkene Customer türünde bir objeyi atadık ve sorun çıkmadı
                // bunun sebebi Customer classının Person classını inherit etmesidir. Person base classtır
                // Bu inheritance sayesinde Customer classına "sen bir Person'sın" diyoruz
                // Classlar onu inherit eden classların referanslarını tutabilmektedir. Base classlar child classların referansını tutabilmektedir

            person3.FirstName = "Emre";
            // yukarıda customer1 objesinin FirstName propertysini "Mehmet" olarak tanımlamıştık
            // daha sonra Person objesi olan person3  objesine customer1 objesini gönderdik. Customer classı Person classını inherit ettiği için yapabildik
            // artık person3 objesi customer1 objesiyle aynı referans adresini tutmaktadır
            // person3 objesinin FirstName propertysini set ettik
            Console.WriteLine(customer1.FirstName);
            // aynı adrese sahip oldukları için person3 objesinde yapılan değişiklik customer1 objesinden de görünecektir

            // bunun yanında Person objesi olarak tutulan person3 objesi her ne kadar Customer classının referansını tutsa da Customer classındaki ek propertyleri boxing etmeden get, set edemez
            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(customer1);
            // gördüğümüz gibi PersonManager classındaki Add metodu bir Person objesi istiyor. Biz de bir Customer objesi yolladık ve çalıştı
            // çünkü Person classı bu Customer objesinin referansını da tutmaktadır
        }
    }
    // classlar üzerinde referans tiplerin incelemesini yapalım
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    // peki base classın onu inherit eden classların referansını tutmasının avantajı ne olacaktır
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
    // genel bir çerçevede çalışacak metodun o türdeki tüm classlarla çalışmasını sağlayabiliriz
        // öreneğin parametre olarak Customer belirlenecek olursa Add metodu sadece Customer türündeki objeler için çalışacaktır
        // Ama Person gönderilirse onu inherit eden tüm classların referanslarını tutabildiği için Person classını inherit eden tüm classlarda çalıştırılabilir
        // Yani Person classını inherit eden tüm classlar aslında birer Person oldukları için Add metodu bu classların hepsiyle çalışabilmektedir
}