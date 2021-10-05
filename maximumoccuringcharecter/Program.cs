using System;

namespace substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloworld = "hello world!";
            string parttolookfor = "hello";

            bool isThere;

            isThere = helloworld.ToLower().Contains(parttolookfor);

            if (isThere)
            {
                Console.WriteLine($"leidsin {parttolookfor} üles!");
            }
            else
            {
                Console.WriteLine($"ei leidnud {parttolookfor}");
            }


        }
    }
}
