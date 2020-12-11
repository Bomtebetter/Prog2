using System;
using System.Collections.Generic;
using System.Text;

namespace AbstraktionLabb
{
    class Dog : Animal
    {
        public Dog()
        {
            Limbs = 4;
        }

        public override void Movement()
        {
            Console.WriteLine("Dog runs around very happily");
        }

        public override void Talk()
        {
            Console.WriteLine("Woof?");
        }
    }
}
