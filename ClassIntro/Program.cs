namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            // aşağıda oluşturduğumuz Course classından bir obje oluşturduk
            // oluştuduğumuz objenin propertylerini tanımlayalım
            course1.courseName = "C#";
            course1.teacher = "Engin Demiroğ";
            course1.viewRate = 2000;

            Course course2 = new Course();
            course2.courseName = "C++";
            course2.teacher = "Emre Küçük";
            course2.viewRate = 3000000;

            Course course3 = new Course();
            course3.courseName = "Python";
            course3.teacher = "Veli Bakırtaş";
            course3.viewRate = 15000;

            Console.WriteLine(course1.courseName + " " + course1.teacher + " " + course1.viewRate);

            // Course objelerinden oluşan Course array
            Course[] courses = new Course[] {course1,course2,course3 };

            //Course[] arrayin elemanlarını foreach ile dolaşma
            foreach (var course in courses)
            {
                Console.WriteLine(course.courseName);
            }
        }
    }

    // C# veri tipleri de aslında birer classtır. Oluşturulan veriler bu classların objeleridir. Diğer bir deyişle c#'ta tüm classlar bir veri tipidir
    // Bizim oluşturacağımız classlara ait objeler üretirken de referans veri tiplerinde ürettiğimiz gibi üreteceğiz
    class Course
    {
        public string courseName { get; set; }
        public string teacher { get; set; }
        public int viewRate { get; set; }

        // oluşturduğumuz class yukarıdaki propertyleri barındırmaktadır
    }

}