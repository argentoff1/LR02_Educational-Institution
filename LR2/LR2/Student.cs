using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class Student : Person
    {
        public string group;
        public Student(string fullName, string group)
        {
            this.fullName = fullName;
            this.group = group;
        }
        public void GetGroup()
        {
            Console.WriteLine(this.group);
        }
    }
}
