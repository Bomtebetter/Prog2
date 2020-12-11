using System;
using System.Collections.Generic;
using System.Text;

namespace AbstraktionLabb
{
    class Hat : Accessories
    {
        public override void Look()
        {
            Console.WriteLine("Hat is dapper");
        }

        public override void Wearable()
        {
            Console.WriteLine("The hat is wearable");
        }
    }
}
