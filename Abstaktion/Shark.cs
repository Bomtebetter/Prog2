using System;
using System.Collections.Generic;
using System.Text;

namespace Abstaktion
{
    class Shark : Animal
    {
        public Shark()
        {
            NumberOfLimbs = 5;
        }

        public override void Breathe()
        {
            Console.WriteLine("Shark be sifting water for oxygen");
        }

        public override void Eat()
        {
            Console.WriteLine("Shark eats people who look like seels");
        }

        public override void Rest()
        {
            Console.WriteLine("Shark is on tha hunt! He will not be sleeping naow!!");
        }
        public void Swim()
        {
            Console.WriteLine("Shark go brrrrrrrrrrrr");
        }
    }
}
