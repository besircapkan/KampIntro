using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Methodlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            
            Console.WriteLine("Sepete Eklendi: "+urun.Adi);
        }

        public void Ekle2(string urun_Adi,string aciklama,double fiyat,int stok_adeti)
        {
            Console.WriteLine("Sepete Eklenmiştir (Ekle2): "+urun_Adi);
        }
    }
}
