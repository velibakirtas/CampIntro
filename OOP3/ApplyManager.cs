using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplyManager // kredi başvuru işlemleri için
    {
        // method injection
        public void ToApply(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            // yapılacak olan başvuruyu hangi kredi türüne göre yapılacağını belirlemek için creditManager parametresini kullanacağız. Bu sayede başvuru tek bir kredi türünden bağımsız hale geldi
                // ICreditManager tüm kredi türlerinin referansını tuttuğu için ICreditManager türünde istedik

            // yapılan başvuruyu aynı zamanda loglamak istediğimiz için kullanılacak loggerları belirlemek için ILoggerService listesini parametre olarak istedik

            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }

        public void GiveCreditPreInformation(List<ICreditManager> credits)
        {
            // önbilgilendirme alınmak istenen kredi türünün sayısı belli değildir. 1 olabilir 100 olabilir.
                // bu sebeple parametre olarak bir List<> kullandık

            foreach(var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
