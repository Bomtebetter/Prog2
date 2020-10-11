using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1
{
    class Person
    {

        public string _name;
        public int _age;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int age
        {
            get { return _age; }
            set { _age = value;  }
        }

        List<Drinks> tab = new List<Drinks>();


        public Person(string name, int age, List<Drinks> tab)
        {
            _name = name;
            _age = age;
            tab = tab;
        }
    }
}
