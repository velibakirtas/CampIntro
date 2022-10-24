using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Customer
    {
        public int Id { get; set; }
        public string CustomerNumber { get; set; }
    }
    // Customer classını base class olarak kullanacağız
    // bu classı inherit eden classlar da birer Customer olacaklar. Customer classı, Customer classını inherit eden classların referanslarını tutabilir
}
