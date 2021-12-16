using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public abstract class Class1
    {
        public string name;
        public string surname;
        public string lastname;

        public string Person(string name, string surname, string lastname)
        {
            this.name = name;
            this.surname = surname;
            this.lastname = lastname;
            return "0";
        }
    }
}
