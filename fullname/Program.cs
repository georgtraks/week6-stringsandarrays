using System;

namespace fullname
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma eesnimi");
            string firstname = Console.ReadLine();
            Console.WriteLine("sisesta oma perekonnanimi");
            string lastname = Console.ReadLine();

            if (firstname.Length > lastname.Length)
            {
                Console.WriteLine("sinu eesnimi on pikem kui perekonnanimi");
            }
            else if (firstname.Length < lastname.Length)
            {
                Console.WriteLine("sinu eesnimi on lühem kui perekonnanimi");
            }
            else
            {
                Console.WriteLine("sama pikad");
            }
            
        }
    }
}
