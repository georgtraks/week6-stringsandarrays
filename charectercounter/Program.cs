using System;

namespace charectercounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma eesnimi");
            string firstname = Console.ReadLine();
            Console.WriteLine("sisesta oma perekonnanimi");
            string lastname = Console.ReadLine();

            string fullname = $"{firstname}{lastname}";



            /*foreach( char charecter in fullname)
            {
                if(charecter == 'a')
                {
                    counter++;
                }
            }*/


            /*int counter = 0;
            int i = fullname.Length-1;

            while(i >= 0)
            {
                Console.WriteLine(fullname[i]);
                if (fullname[i] == 'a')
                {
                    
                    counter++;
                }
                i--;
            }*/







            


            int counter = 0;

            for(int i = 0; i < fullname.Length; i++)
            {
                if (fullname[i] == 'a')
                {
                    counter++;
                }
            }


            Console.WriteLine($"sinu nimes on {counter} a-tähte");

        }
    }
}
