using System;

namespace ÖppethusLek
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.WriteLine("Hejsan vad heter du?");
            person.Name = Console.ReadLine();

            if (person.Name.ToLower() == "petter")
            {
                Console.WriteLine("Eyy fint namn");
            }

            Console.WriteLine("\n" + person.Name + " vilken årskurs går du i?");
            person.Klass = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n" + "Vilket program intresserar dig?");
            person.Program = Console.ReadLine();

            Console.WriteLine("Vad kul att " + Ïnriktning.Program + " intresserar dig!");

            if (person.Program.ToLower() == "teknik")
            {
                Console.WriteLine("\n" + "Jasså är du intresserad av " + person.Program + "!");
                Console.WriteLine(person.Program + " har 2 olika inriktningar, Software och Engineering. Vilken inresserar dig mest?");

            }
            else if (person.Program.ToLower() == "natur")
            {
                Console.WriteLine("\n" + "Jasså är du intresserad av " + person.Program + "!");
                Console.WriteLine(person.Program + " har 2 olika inriktningar, Master och Biotech. Vilken inresserar dig mest?");
            }
        

            if (person.Klass == 9)
            {
                Console.WriteLine("Hoppas vi ser dig på skolan nästa år!");
            }
            else if (person.Klass  == 8 )
            {
                Console.WriteLine("Hoppas vi ser dig om två år på skolan!");
            }
            else if (person.Klass == 7 )
            {
                Console.WriteLine("Hoppas vi ser dig om tre år på skolan!");
            }
            else
            {
                Console.WriteLine("Jasså går du går inte på högstadiet asså...");
            }


        }
    }
}
