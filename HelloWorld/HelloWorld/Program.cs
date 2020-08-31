using System;
using System.Net.Cache;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Niklas!");

            String _Name = String.Empty;
            int _Age = 0;
            Boolean _AliveCheck = true;


            _Name = Name(_Name);
            _Age = Age(_Age);
            _AliveCheck = Alive(_AliveCheck);
            InfoPrint(_Name, _Age, _AliveCheck);
            MathPart();
        }

        static string Name(String _Name)
        {
            Console.WriteLine("\n Whats your name?");
            _Name = Console.ReadLine();

            return _Name;
        }

        static int Age(int _Age)
        {
            Console.WriteLine("How old are you?");
            _Age = Convert.ToInt32(Console.ReadLine());

            return _Age;
        }

        static Boolean Alive(Boolean _AliveCheck)
        {
            Console.WriteLine("Are you alive?");
            String Answer = Console.ReadLine();
            if (Answer.ToLower() == "yes")
            {
                _AliveCheck = true;
            }
            else
            {
                _AliveCheck = false;
            }
            

            return _AliveCheck;
        }

        static void InfoPrint(String _Name, int _Age, Boolean _AliveCheck)
        {
            Console.WriteLine("\n Your name is " + _Name);
            Console.WriteLine("You are " + _Age + " years old");
            if (_AliveCheck == true)
            {
                Console.WriteLine("Congratulations you are still alive!!");
            }
            else
            {
                Console.WriteLine("Sorry for your loss...");
            }
            
        }
        static void MathPart()
        {
            Console.WriteLine("\n Write two numbers in two inputs and I will tell you which is bigger!");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            int Number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Max(Number1, Number2) + " Is the bigger number!");
        }
    }
}
