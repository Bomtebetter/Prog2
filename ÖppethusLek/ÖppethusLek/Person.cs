using System;
using System.Collections.Generic;
using System.Text;

namespace ÖppethusLek
{
    class Person
    {

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _klass;

        public int Klass
        {
            get { return _klass; }
            set { _klass = value; }
        }

        private string _program;

        public string Program
        {
            get { return _program; }
            set { _program = value; }
        }


    }
}
