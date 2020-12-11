using System;
using System.Collections.Generic;
using System.Text;

namespace AbstraktionLabb
{
    class Bird : Animal
    {
        public Bird()
        {
            Limbs = 2;
        }
        public override void Movement()
        {
            Console.WriteLine("Råger do be flying");
        }

        public override void Talk()
        {
            Console.WriteLine("Råger goes chirp chirp");
        }
    }
}
