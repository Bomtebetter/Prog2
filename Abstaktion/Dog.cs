﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Abstaktion
{
    class Dog : Animal
    {
        public Dog()
        {
            NumberOfLimbs = 4;
        }
        public override void Breathe()
        {
            Console.WriteLine("Dog takes a deep breath");
        }

        public override void Eat()
        {
            Console.WriteLine("Dog eat food");
        }

        public override void Rest()
        {
            Console.WriteLine("Dog goes ZZZzzzZZZzzz...");
        }
    }
}
