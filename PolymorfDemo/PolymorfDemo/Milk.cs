using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorfDemo
{
    class Milk : Product
    {

        private int _fatPercentage;

        public int FatPercentage
        {
            get { return _fatPercentage; }
            set { _fatPercentage = value; }
        }

    }
}
