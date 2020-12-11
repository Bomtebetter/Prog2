using System;
using System.Collections.Generic;
using System.Text;

namespace AbstraktionLabb
{
    abstract class Animal
    {

        public abstract void Movement();

        public abstract void Talk();

        public int Limbs { get; set; }

        public string age { get; set; }


    }
}
