using System;

namespace substitutechatecter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma eesnimi");
            string firstname = Console.ReadLine();
            Console.WriteLine("sisesta oma perekonnanimi");
            string lastname = Console.ReadLine();

            string fullname = $"{firstname}{lastname}".ToLower();

           fullname = fullname.Replace('a', '*');

            Console.WriteLine(fullname);


        }    
    }
}
