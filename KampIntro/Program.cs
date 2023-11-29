using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Değişkenler type safety şeklindedir ( tip güvenliği)
            // Başka bir benzetme yapmak gerekirse, tür güvenliğini bir evin inşasına benzetebiliriz.
            // Bir ev inşa ederken, doğru malzemeleri kullanmamız gerekir.
            // Aksi takdirde, ev sağlam olmayacaktır.


            // Bir Değişken Aşşağıdaki Gibi Oluşuyor ( string türünde );
            string kategori_etiketi = "Kategori";

            // sayısal bir değişken oluşturduk 
            int ogrenci_sayisi = 32000;

            // ondalıklı bir değişken double veri tipiyle gösteriyoruz
            double faiz_orani = 1.45;

            // doğru mu veyahut yanlış mı ona göre sonuç döndüren veri tipimiz bool
            // sadece true veyahut false sonuç döndürür
            bool sisteme_giris_yapmis_mi = false;


            // if ( yani eğer demektir eğer şöyle olmazsa böyle yap gibisinden mantık kurabiliriz);
            if (sisteme_giris_yapmis_mi)
            {
                Console.WriteLine("Hosgeldiniz");
            }
            // eğer if çalışmazsa else çalışır
            // (bool sisteme_giris_yapmis_mi = false;) bu kodda bakın false eğer if de true yoksa elseye gider
            else
            {
                Console.WriteLine("Giriş Yapılmadı");
            }



            double dolar_dun = 7.55;
            double dolar_bugun = 7.65;

            if (dolar_dun>dolar_bugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else if (dolar_dun==dolar_bugun)
            {
                Console.WriteLine("Stabil");
            }
            else
            {
                Console.WriteLine("Azalış Butonu");
            }

            Console.WriteLine(kategori_etiketi);

        }
    }
}
