using System;
using System.Collections.Generic;
using System.Text;

namespace PolyLabb
{
    class Apple : Product
    {

        private string _sweetness;

        public string Sweetness
        {
            get { return _sweetness; }
            set { _sweetness = value; }
        }
        private int _amount;

        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }


    }
}
