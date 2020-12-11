using System;
using System.Collections.Generic;
using System.Text;

namespace AbstraktionLabb
{
    class Toy : Accessories
    {
        public override void Look()
        {
            Console.WriteLine("The toy looks very fun");
        }

        public override void Wearable()
        {
            Console.WriteLine("The toy is not wearable");
        }
    }
}
