// See https://aka.ms/new-console-template for more information
using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, decimal, float, enum, boolean değer tiptir. (values types)
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("Sayı 1: "+ sayi1);
            Console.WriteLine(sayi2);
            //Console.BackgroundColor = ConsoleColor.Red;

            // array

            int[] sayilar1=new int[] {1,2,3};
            int[] sayilar2=new int[] {10,20};
            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine(sayilar1[0]);



        }
    }
}



//Console.WriteLine("Hello, World!");
