using System;
using System.Collections.Generic;
using System.Text;

namespace ÖppethusLek
{
    class Inriktning : Person
    {

        private string _program;
        public string Program
        {
            get { return _program; }
            set { _program = value; }
        }
    }
}
