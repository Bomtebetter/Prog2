using System;
using System.Linq;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] _words = {"penis ", "kuk ", "schlong ", "dong " };
            int[] _number = { 1, 2, 3, 4 };

            Console.WriteLine(Ord(_words));
            Console.WriteLine(Summa(_number));

            int[] bigAndSmall = BigAndSmall(_number);
            for(int i = 0; i < bigAndSmall.Length; i++)
            {
                Console.WriteLine(bigAndSmall[i]);
            }

        }

        static string Ord(string[] _words)
        {
            Array.Reverse(_words);
            string result = String.Concat(_words);
            return result;
        }

        static int Summa(int[] nummer)
        {
            var sum = 0;
            for(int i = 0; i < nummer.Length; i++)
            {
                sum = sum +  nummer[i];
            }

            return sum;
        }

        static int[] BigAndSmall(int[] number)
        {
            int biggest = number.Max();
            int smallest = number.Min();
            int[] bigAndSmall = { biggest, smallest };

            
            return bigAndSmall;
        }
    }
}
