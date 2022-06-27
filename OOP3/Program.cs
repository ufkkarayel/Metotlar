using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();            
            IKrediManager tasitKrediManager=new TasitKrediManager();   
            IKrediManager konutKrediManager= new KonutKrediManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService= new FileLoggerService();
            
            BasvuruManager basvuruManager=new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager,databaseLoggerService);
            // interfaceleri birbirinin alternatifi olan ancak içeriği farklı olan türler için kullanırız.
            List<IKrediManager> krediler=new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}



