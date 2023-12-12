using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1T5M9_11.Entities
{
    class Department
    {
        public string _name { get; private set; }

        public Department(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return $"Department's name --> {_name}";
        }
    }
}
