using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorfDemo
{
    class Coffee : Product
    {

        private string _roastyness;

        public string Roastyness
        {
            get { return _roastyness; }
            set { _roastyness = value; }
        }


    }
}
