using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
        //anotasyondaki 'T' generic yapının alacağı herhangi bir veri tipini ifade etmektedir. bkz:Type
    {
        T[] items;
        // T arrayinin newlenmesi gerekmektedir. Bunu da class constructorında yapacağız

        // constructor: class newlendiğinde çalışan bloktur
        public MyList()
        {
            //MyList<> generic classından bir obje oluşturulduğunda bu constructor metot otomatik olarak çalışmaktadır
            items = new T[0];
        }
        public void Add(T item)
        {
            // burada metodun beklediği parametre olarak T gönderdik bu da bu generic class newlenirken kullanılacak verinin tipi ne olursa metodun da bu veri tipini kullanmasını sağlar

            T[] tempArray = items;
            items = new T[items.Length + 1];
            // metot her çalıştığında T arrayinin eleman sayısı var olan eleman sayısından 1 fazla olacak şekilde düzenlenecektir.
            // fakat metot her kullanıldığında yeni bir obje oluşmuş olacak bu sebeple yeni obje oluşmadan önceki arrayin tuttuğu veriler kaybolacaktır
            // veri barındıran bir önceki arrayin kaybolmaması için en son oluşturulan arrayin referansını geçici bir T arraye gönderdik
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            // daha sonra tempArray arrayindeki elemanları bulunduracak şekilde items arrayini düzenliyoruz.
            // ilk elemandan[0] başlayacak şekilde tempArray eleman sayısı kadar döngü devam eder

            items[items.Length-1] = item;
            // son olarak eklemek istediğimiz elemanı arrayin son elemanı olarak ekledik. eleman sayısı-1:son index
        }

        // arraydeki eleman sayısnı döndüren bir metot yazalım
        public int Count 
        { 
            get { return items.Length; } 
        }
    }
}
