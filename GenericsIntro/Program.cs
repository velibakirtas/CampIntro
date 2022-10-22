namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> names2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            // c# ta hazır bulunan generic List<> classını kullandık

            // kendi oluşturduğumuz generic MyList<> class
            MyList<string> names = new MyList<string>();
            // generic classta newlenirken(collection oluşturulurken) alınacak veri tipini T olarak belirlemiştik. Burada string gönderdik. Böylece bu object için T, string veri tipinin yerini tutmaktadır
            names.Add("Engin");
            names.Add("Ali");
            names.Add("Veli");

            // metot parametresinde de yine T kullanmıştık. Bu sayede collections oluşturulurken kullanılan veri tipi ne ise metotta o veri tipinde bir veri isteyecektir

            Console.WriteLine(names.Count);
        }
    }
}