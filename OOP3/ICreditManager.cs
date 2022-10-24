using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface ICreditManager
    {
        void Calculate();
        
        // Calculate metodu CreditManagerı inherit eden tüm classlarda kullanabilecektir
        // Fakat her bir kredinin hesaplanması için farklı yöntemler ve veriler gerekebilir. Örn: faiz oranı, vade sınırları vs.
        // Bu sebeple sadece parent görevi görmesi için yalnızca imzasını burada tutarak implemente edilecek classlarda bloğu doldurabiliriz
        // bu yapılara "interface" adı verilir
        // yani aslında interfaceler base görevi gören şablonlardır diyebiliriz

        // eğer bir class interface'i kullanırsa o class interfaceteki metodu içermek zorundadır

        // okunurluğu artırmak için interfaceler "I" ile başlar
        // genellikle "Service" ile isimlendirilirler. Örn: ICreditService

        // interfaceler newlenemez yani interfacelerden obje oluşturulamaz

        // interfaceler birbirinin alternatifi ama kod içerikleri farklı olan durumlar için kullanılır
        // bir diğer en önemli sebebi referans tutucu olarak kullanılmasıdır
    }
}
