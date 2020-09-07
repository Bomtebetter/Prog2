using System;

namespace Vilkor_och_Loopar
{
    class Program
    {
        static void Main(string[] args)
        {
            int _Number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; _Number >= i; i++)
            {
                Console.WriteLine(i);
            }

            while (true)
            {
                Console.WriteLine("Are you happy?");
                String happiness = Console.ReadLine();
                if(happiness.ToLower() == "no")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

            int month = 12;
            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("Mars");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
               

            }
        }
    }
}
