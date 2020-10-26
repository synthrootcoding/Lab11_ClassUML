using System;
using System.Collections.Generic;
using System.Text;

namespace Labb11_UML
{
    class Staff : Person
    {
        public string School { get; set; }
        public double Pay { get; set; }
        
        public Staff(string Name, string Address) :base(Name, Address)
        {

        }

        public Staff(string Name, string Address, string School, double Pay) :base(Name, Address)
        {
            this.School = School;
            this.Pay = Pay;
        }
        public override string ToString()
        {
            return $"[Name: {Name}] [Address: {Address}] [School: {School}] [Pay: {Pay}]";
        }
    }
}
