using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urun_adi = "Elma";
            double fiyati = 15;
            string urun_aciklamasi = "Amasya Elması";

            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Muz";
            urun1.Aciklama = "Yerli Muz";
            urun1.Fiyati = 15;

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Karpuz";
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.Fiyati = 3;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun_don in urunler)
            {
                Console.WriteLine("Ürün İsmi:"+urun_don.Adi);
                Console.WriteLine("Ürün Açıklaması:"+urun_don.Aciklama);
                Console.WriteLine("Ürün Fiyatı: "+urun_don.Fiyati);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("-------------------METHODLAR---------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Çilek", "Bahçe Çilek", 25,500);
            sepetManager.Ekle2("erik", "Can Eril", 66,145);
            sepetManager.Ekle2("Ayva", "Mağra Ayvası", 43,654);

        }
    }
}
