using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return Name;
        }
    }
}
