using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
           Urun urun1 = new Urun();
            urun1.ID = 1;
            urun1.Adi = "Elma";
            urun1.Fiyati = 15.90;
            urun1.Aciklama = "Golden";

            Urun urun2 = new Urun();
            urun2.ID = 2;
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 4.50;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2, };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.ID);
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------------");
                
            }
            Console.WriteLine("--------Metotlar---------");

            //instance- örneği oluşturulur

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            Console.Read();
        }
    }
}
