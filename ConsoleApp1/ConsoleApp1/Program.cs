using Prog2Labb1;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Service cockAndBallTorture = new Service();
            Customer customer = new Customer();

            Console.WriteLine("Yoda says : What is young padawans name?");
            customer.Name = Console.ReadLine();

            Console.WriteLine("Yoda says : Hello " + customer.Name + " see i do that you want cock and ball torture." );
            Console.WriteLine("How many hours yet i do not know");
            cockAndBallTorture.Hours = Convert.ToInt32(Console.ReadLine());
            customer._order.Add(cockAndBallTorture);

            foreach (var Service in customer._order)
            {
                Console.WriteLine("Yoda says: Crush your cock with a rock i must, maximum pain you must endure!");
                Console.WriteLine(customer.Name + " AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAa");
            }
        }
    }
}
