using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    public class Teacher : Worker
    {
        public Teacher(string name, string middlename, string surname)
            : base(name, middlename, surname, "Преподаватель") { }
        private int lecture;
        private Group group = null;
        public int Lecture
        {
            set
            {
                if (group != null) this.lecture = value;
            }
            get
            {
                return (this.lecture);
            }
        }
        public void Lectured()
        {
            this.lecture--;
        }
        public void SetGroup(Group group)
        {
            this.group = group;
        }
    }
}
