// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<string> isimler = new List<string>();
        isimler.Add("Ufuk");
        isimler.Add("Aysun");
        isimler.Add("Defne");
        Console.WriteLine(isimler[0]);
        Console.WriteLine(isimler[1]);
        Console.WriteLine(isimler[2]);
        isimler.Add("Deniz");
        Console.WriteLine(isimler[3]);
    }
}


