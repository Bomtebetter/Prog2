using System;
using System.Collections.Generic;
using System.Text;

namespace AbstraktionLabb
{
    class Cat : Animal
    {
        public Cat()
        {
            Limbs = 4;
        }
        public override void Movement()
        {
            Console.WriteLine("The cat moves as quiet as a ninja");
        }

        public override void Talk()
        {
            Console.WriteLine("MEEEOOOOOOOOOOOOWWW!!!!");
        }
    }
}
