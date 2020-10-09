using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorfDemo
{
    class Monster : Product
    {
        

        private string _flavour;

        public string Flavour
        {
            get { return _flavour; }
            set { _flavour = value; }
        }

    }
}
