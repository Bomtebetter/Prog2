using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1
{
    class AlcoholicDrinks
    {
        public int _cost;
        public string _name;
        public int _amount;

        public int amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public AlcoholicDrinks(string drinkname, int amount)
        {
            _name = drinkname;
            _cost = 45;
            _amount = amount;

        }

    }
}
