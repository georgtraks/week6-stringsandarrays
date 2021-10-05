using System;

namespace ForEachv2
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloworld = "Hello World!";

            int counter = 0;

            foreach (char charecter in helloworld)
            {
                counter = counter + 1;



            }
            Console.WriteLine($"{helloworld} on {counter} sümbolit pikk.");

        }
    }
}
