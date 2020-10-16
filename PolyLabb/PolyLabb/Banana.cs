using System;
using System.Collections.Generic;
using System.Text;

namespace PolyLabb
{
    class Banana : Product
    {

        private string _curvature;

        public string Curvature
        {
            get { return _curvature; }
            set { _curvature = value; }
        }
        private int _amount;

        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

    }
}
