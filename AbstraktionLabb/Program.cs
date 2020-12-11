using System;
using System.Collections.Generic;

namespace AbstraktionLabb
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Animal> animals = new List<Animal>();

            var dog = new Dog();
            dog.age = "1 year old";

            var cat = new Cat();
            cat.age = "2 and a half years old";

            var bird = new Bird();
            bird.age = "Only 1 month old";

            List<Accessories> accessories = new List<Accessories>();

            var hat = new Hat();
            hat.Colour = "Black";
            hat.Size = "Uni-size";

            var necklace = new Necklace();
            necklace.Colour = "Orange";
            necklace.Size = "Uni-size";

            var toy = new Toy();
            toy.Colour = "A mix of yellow and blue";
            toy.Size = "Uni-size";

            string answer = string.Empty;

            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Do you want to buy a puppy?");
                    answer = Console.ReadLine();
                    if (answer.ToLower() == "yes")
                    {
                        animals.Add(dog);
                        answer = string.Empty;
                    }
                    Console.WriteLine("Do you want to buy a cat?");
                    answer = Console.ReadLine();
                    if (answer.ToLower() == "yes")
                    {
                        animals.Add(cat);
                        answer = string.Empty;
                    }
                    Console.WriteLine("Do you want to buy a bird?");
                    answer = Console.ReadLine();
                    if (answer.ToLower() == "yes")
                    {
                        animals.Add(bird);
                        answer = string.Empty;
                    }
                    Console.WriteLine("Do you want to buy a hat for your animal?");
                    answer = Console.ReadLine();
                    if (answer.ToLower() == "yes")
                    {
                        accessories.Add(hat);
                        answer = string.Empty;
                    }
                    Console.WriteLine("Do you want to buy a necklace for your animal?");
                    answer = Console.ReadLine();
                    if (answer.ToLower() == "yes")
                    {
                        accessories.Add(necklace);
                        answer = string.Empty;
                    }
                    Console.WriteLine("Do you want to buy a toy for your animal?");
                    answer = Console.ReadLine();
                    if (answer.ToLower() == "yes")
                    {
                        accessories.Add(toy);
                        answer = string.Empty;
                    }

                    Console.WriteLine("Are you done with your order?");
                    answer = Console.ReadLine();
                    if (answer.ToLower() == "yes")
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }

                }

                Console.WriteLine("Here is what you got: ");

                foreach (var animal in animals)
                {
                    animal.Movement();
                    animal.Talk();
                    Console.WriteLine(animal.Limbs);
                    Console.WriteLine(animal.age);
                }

                foreach (var accessory in accessories)
                {
                    accessory.Wearable();
                    accessory.Look();
                    Console.WriteLine(accessory.Colour);
                    Console.WriteLine(accessory.Size);
                }

                break;

            }


        }
    }
}
