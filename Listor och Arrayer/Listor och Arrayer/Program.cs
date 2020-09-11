using System;

namespace Listor_och_Arrayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] namn= new string[5];

            Console.WriteLine("Write 5 names in 5 different inputs");
            for(int i = 0; i < 5; i++)
            {
                namn[i] = Console.ReadLine();
            }
            
            for (int i = 4; i > -1; i--)
            {
                Console.WriteLine(namn[i]);
            }
        }
    }
}
