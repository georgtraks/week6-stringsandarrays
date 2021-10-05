using System;

namespace fullnamereverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma eesnimi");
            string firstname = Console.ReadLine();
            Console.WriteLine("sisesta oma perekonnanimi");
            string lastname = Console.ReadLine();

            for (int i = firstname.Length - 1; i >= 0; i--)
            {
                Console.Write(firstname[i]);
            }

            for (int i = lastname.Length - 1; i >= 0; i--)
            {
                Console.Write(lastname[i]);
            }





        }
    }
}
