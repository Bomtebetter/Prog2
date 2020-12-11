using System;
using System.Collections.Generic;

namespace Abstaktion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            var dog = new Dog();
            dog.Colour = "Black";

            var shark = new Shark();
            shark.Colour = "Gray";

            animals.Add(dog);
            animals.Add(shark);

            foreach (var animal in animals)
            {
                animal.Breathe();
                animal.Eat();
                animal.Rest();

                if (animal is Shark tempShark)
                {
                    tempShark.Swim();
                }
            }

        }
    }
}
