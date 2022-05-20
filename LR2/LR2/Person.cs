using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    public abstract class Person
    {
        private string name;
        private string middlename;
        private string surname;

        public Person(string name, string middlename, string surname)
        {
            this.name = name;
            this.surname = surname;
            this.middlename = middlename;
        }
        public string GetAllFullName()
        {
            string[] fullName = new string[] { this.middlename, this.surname };
            string allFullName = name;
            foreach (string i in fullName)
            {
                if (i != null)
                {
                    allFullName = allFullName + " " + i;
                }
            }
            return (allFullName);
        }
    }
}
