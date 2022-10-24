namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // gerçek müşteri
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.FirstName = "Veli";
            customer1.LastName = "Bakırtaş";
            customer1.IdentityNumber = "123456788910";

            // tüzel müşteri
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "MKS";
            customer2.TaxNumber = "1234567890";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();
            // IndividualCustomer ve CorporateCustomer classları Customer classlarını inherit ettikleri için Customer classı bu classların referanslarını tutabilmektedir

            // bu sayede CustomerManager classında Customer türünde parametre bekleyen Add metoduna yukarıdaki tüm objeleri gönderebiliriz
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
            // parametre olarak Customer ve onu inherit eden tüm classları gönderebiliyor olmamıza "polymorphism" denir
        }
    }
}