using System;
using System.Collections.Generic;

namespace Labb1
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Drinks> tab = new List<Drinks>();

            Console.WriteLine("Welcome to my bar!");

            Console.WriteLine("What's your name?");
            string namn = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            Person person = new Person(namn, age, tab);

            AlcoholicDrinks lager = new AlcoholicDrinks("lager", 0);
            AlcoholicDrinks cider = new AlcoholicDrinks("cider", 0);
            AlcoholicDrinks stout = new AlcoholicDrinks("stout", 0);

            NonAlcoholicDrinks coke = new NonAlcoholicDrinks("coke", 0);
            NonAlcoholicDrinks fanta = new NonAlcoholicDrinks("fanta", 0);
            NonAlcoholicDrinks sprite = new NonAlcoholicDrinks("sprite", 0);

            Console.WriteLine("Are you ready to order your drink?");
            string answer1 = Console.ReadLine();
            string order = string.Empty;
            
            if (answer1.ToLower() == "yes" )
            {
                if (person.age >= 18)
                {
                    Console.WriteLine("We have: " + lager.name + ", " + cider.name + ", " + stout.name + ", " + coke.name + ", " + fanta.name + ", " + sprite.name);
                    Console.WriteLine("How many " + lager.name + " do you want?");
                    lager.amount = Convert.ToInt32(Console.ReadLine());
                    tab.Add(lager);

                    Console.WriteLine("How many " + cider.name + " do you want?");
                    cider.amount = Convert.ToInt32(Console.ReadLine());
                    tab.Add(cider);

                    Console.WriteLine("How many " + stout.name + " do you want?");
                    stout.amount = Convert.ToInt32(Console.ReadLine());
                    tab.Add(stout);

                    Console.WriteLine("How many " + coke.name + " do you want?");
                    coke.amount = Convert.ToInt32(Console.ReadLine());
                    tab.Add(coke);

                    Console.WriteLine("How many " + fanta.name + " do you want?");
                    fanta.amount = Convert.ToInt32(Console.ReadLine());
                    tab.Add(fanta);

                    Console.WriteLine("How many " + sprite.name + " do you want?");
                    sprite.amount = Convert.ToInt32(Console.ReadLine());
                    tab.Add(sprite);

                    int cost = (lager.amount * lager._cost) + (cider.amount * cider._cost) + (stout.amount * stout._cost) + 
                        (coke.amount * coke._cost) + (fanta.amount * fanta._cost + (sprite.amount * sprite._cost));
                    Console.WriteLine(tab);
                    Console.WriteLine("Your total cost comes to: " + cost + " Swedish crowns");
                }
                else
                {
                    Console.WriteLine("We have: " + coke.name + ", " + fanta.name + ", " + sprite.name);
                    Console.WriteLine("How many " + coke.name + " do you want?");
                    coke.amount = Convert.ToInt32(Console.ReadLine());
                    tab.Add(coke);

                    Console.WriteLine("How many " + fanta.name + " do you want?");
                    fanta.amount = Convert.ToInt32(Console.ReadLine());
                    tab.Add(fanta);

                    Console.WriteLine("How many " + sprite.name + " do you want?");
                    sprite.amount = Convert.ToInt32(Console.ReadLine());
                    tab.Add(sprite);

                    int cost = (coke.amount * coke._cost) + (fanta.amount * fanta._cost + (sprite.amount * sprite._cost));
                    Console.WriteLine(tab);
                    Console.WriteLine("Your total cost comes to: " + cost + " Swedish crowns");

                }

            }
            else
            {
                Console.WriteLine("Bye bye " + person.name);
            }

        }
    }
}
