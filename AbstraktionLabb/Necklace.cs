using System;
using System.Collections.Generic;
using System.Text;

namespace AbstraktionLabb
{
    class Necklace : Accessories
    {
        public override void Look()
        {
            Console.WriteLine("The necklace looks cuuute");
        }

        public override void Wearable()
        {
            Console.WriteLine("The necklace is wearable");
        }
    }
}
