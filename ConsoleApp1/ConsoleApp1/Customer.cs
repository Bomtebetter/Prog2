using System;
using System.Collections.Generic;
using System.Text;

namespace Prog2Labb1
{
    class Customer
    {
        public List<Service> _order = new List<Service>();

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


    }
}
