using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;
            // böyle yapmaktansa classlarda çalışmak daha iyidir
            // classlar herbirini kendi içersinde toplar

            // bir class çağırma aşşağıdaki gibidir
            Kurs kurs1 = new Kurs();
            kurs1.Egitmeni="Engin Demiroğ";
            kurs1.Kurs_adi = "C#";
            kurs1.Izlenme_orani = 7;

            Kurs kurs2 = new Kurs();
            kurs2.Egitmeni = "Engin Demiroğ";
            kurs2.Kurs_adi = "Java";
            kurs2.Izlenme_orani = 4;

            Kurs kurs3 = new Kurs();
            kurs3.Egitmeni = "Engin Demiroğ";
            kurs3.Kurs_adi = "Python";
            kurs3.Izlenme_orani = 9;

            // kurs adında bir array oluşturyoruz
            // bunun ismini kurslar yapıyoruz
            // ve bunun içine sadece kurs classının içinden alıyoruz 
            // üst tarafta kurs clasının özelliklerini tanımladığımız 3 kursumuzu atıyoruz.
            // oluşturduğumuz kurs arrayının içinde verilerini girdiğimiz kursun özelliklerini atıyoruz.
            // Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3}; bu şekilde 3 kursu da içine entegre ettik
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

            foreach (var kurslarım in kurslar)
            {
                Console.WriteLine("Kursun Adı : "+" : "+kurslarım.Kurs_adi+" Kursun Eğitmeni: "+" : "+kurslarım.Egitmeni);
            }

        }
    }



    // işte bir clas oluşturma özellik ekleme ise 
    // prop + tap tap tuşuna basıyorsunuz 
    //public "duruma göre değişken sen belirliyorsun" "ismi" { get; set; }
    class Kurs
    {
        public string Kurs_adi { get; set; }
        public string Egitmeni { get; set; }
        public int Izlenme_orani { get; set; }

    }
}
