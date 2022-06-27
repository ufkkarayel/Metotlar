// See https://aka.ms/new-console-template for more information
using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
        //gerçek müşteri
        IndividualClient client1 = new IndividualClient();
            client1.Id = 1;
            client1.Name = "Ufuk";
            client1.ClientNo = "4335";
            client1.LastName = "Karayel";
            client1.TcNo = "12345678911";

        // tüzel müşteri

            CorporateClient client2 = new CorporateClient();    
            client2.Id = 2;
            client2.CorporationName = "Kodlama.io";
            client2.VergiNo = "2244556677";
            client2.ClientNo = "1234";


            Customer customer1 = new IndividualClient();
            Customer customer2 = new CorporateClient();

            ClientManager clientManager1 = new ClientManager();
            clientManager1.Add(customer1);
            clientManager1.Add(customer2);
            clientManager1.Add(client1);
            clientManager1.Add(client2);


        }
    }
}


