using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditManager needCreditManager = new NeedCreditManager();
            

            ICreditManager vehicleCreditManager = new VehicleCreditManager(); 
             

            ICreditManager housingCreditManager = new HousingCreditManager();


            // interfaceler de o interfacei implemente eden classın referansını tutabildiği için polymorphism ile geçerli classta konfigüre edilmiş metodu çalıştıracaktır

            List<ILoggerService> fileLoggerServices = new List<ILoggerService>() {new FileLoggerService() };

            ApplyManager applyManager = new ApplyManager();
            applyManager.ToApply(needCreditManager,
                new List<ILoggerService>() { new DatabaseLoggerService(), new FileLoggerService()}); 
            // gönderilecek parametre objesi parametre içinde de newlenebilir

            applyManager.ToApply(vehicleCreditManager, new List<ILoggerService> {new DatabaseLoggerService() }); 
            applyManager.ToApply(housingCreditManager, fileLoggerServices); 


            List<ICreditManager> credits = new List<ICreditManager>() {needCreditManager, vehicleCreditManager };

            applyManager.GiveCreditPreInformation(credits);
            // ön bilgilendirme yapan metot bir ICreditManager listesi beklemektedir. Yukarıda oluşturduğumuz listeyi bu metoda parametre olarak gönderdik
        }
    }
}