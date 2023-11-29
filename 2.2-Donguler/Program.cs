using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yerleştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            // böyle tek tek tanımlaymayız 1000 tane kurs olsa tek tek girmek saçmalık
            // ama dizilerde tanımlayabiliriz 


            // basit döngüler
            // for dönügüs;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // array - diziler ( listeler yani)

            string[] kurslar = new string[] { "Yazılım Geliştirici Yerleştirme Kampı",
                "Programlamaya Başlangıç İçin Temel Kurs",
                "Java"};

            for (int x = 0; x < kurslar.Length; x++)
            {
                Console.WriteLine(kurslar[x]);
            }


            foreach (var kursum in kurslar)
            {
                Console.WriteLine(kursum);
            }



   
        }
    }
}
