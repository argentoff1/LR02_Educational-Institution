using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class Teacher : Worker
    {
        public Teacher(string fullName, string position)
        {
            this.fullName = fullName;
            this.position = position;
        }
    }
}
