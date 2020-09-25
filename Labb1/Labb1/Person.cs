using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1
{
    class Person
    {

        public string _name;
        public int _age;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value;  }
        }
    }
}
