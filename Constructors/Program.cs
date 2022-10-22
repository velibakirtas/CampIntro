namespace Constructors // constructorlar (yapıcı blok) bir class newlendiğinde bir kere otomatik olarak çalışan bloktur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Veli", LastName = "Bakırtaş", City = "İstanbul" };
            // burada bir constructor kullanılmamış gibi fakat newlendiğinde arka planda bir default constructor blok çalışmaktadır

            Customer customer2 = new Customer();
            // Burada ise default constructor ile instance oluşturduk. 

            Customer customer3 = new Customer(3,"Ahmet", "Mehmet", "Ankara");
            // burada da farklı bir constructor ile instance oluşturduk
        }
    }

    class Customer
    {
        public Customer() // constructor blok
        {
            // constructorlar aslında bir metot gibi çalışır. Dolayısıyla constructor metotları da parametre alabilirler
            // manuel olarak bir constructor oluşturulmamış olsa bile arka planda default bir constructor çalışmaktadır

         }

        // parametre alan bir constructor oluşturalım
        public Customer(int id, string firstName, string lastName, string city)
        {
            // alınan parametrelerin tanımlanması için propertylere parametrelerin atanması yapılmalıdır
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.City = city;
            // this kwsi oluşturulmuş olan instancein referansını tutar
                // customer3 instancinden açıklayacak olursak: customer3 instanceinin Id propertysine constructor parametresindeki id değerini atadık. Diğerleri de bu şekilde
        }
        // eğer default constructor yerine başka bir constructor oluşturursak bu oluşturulan yeni constructor default constructorı ezer. 
        // overloading ile birden fazla constrcutor blok oluşturulabilir
        // burada hem default constructor hem de farklı bir signaturea sahip başka bir constructorı kullanabiliriz

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}