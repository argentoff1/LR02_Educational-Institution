using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class Person
    {
        public string fullName;

        public void GetFullName()
        {
            Console.WriteLine($"ФИО: {this.fullName}");
        }
    }
}
