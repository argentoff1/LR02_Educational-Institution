using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    public class Student : Person
    {
        public Student(string name, string middlename, string surname) : base(name, middlename, surname) { }
        public Group group;
        public bool studies = true;

        public string GetGroup()
        {
            return (this.group.NameGroup);
        }
        public void Deducted()
        {
            this.studies = false;
            group.UpData();
        }
    }
}
