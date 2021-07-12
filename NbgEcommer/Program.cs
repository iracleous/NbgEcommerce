using NbgEcommerce.Service;
using System;

namespace NbgEcommerce
{


    public static  class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat { Name="Mimika", Gender="F", Breed="Agkiras" };
            Console.WriteLine("Hello "+ cat.Name);
            Console.WriteLine(cat.Speak());

            Console.WriteLine("My weight is " + Utility.ConvertGramToKilos(80000));

        }
    }
}
