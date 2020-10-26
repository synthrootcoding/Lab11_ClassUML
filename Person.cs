using System;
using System.Collections.Generic;
using System.Text;

namespace Labb11_UML
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Person() { }

        public Person(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }

        public override string ToString()
        {
            return $"[Name: {Name}] [Address: {Address}]";
        }
    }
}
