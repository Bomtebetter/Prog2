using System;
using System.Collections.Generic;
using System.Text;

namespace PolyLabb
{
    class Orange : Product
    {

        private int _cleftAmount;

        public int Clefts
        {
            get { return _cleftAmount; }
            set { _cleftAmount = value; }
        }
        private int _amount;

        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

    }
}
