using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    public abstract class Worker : Person
    {
        private string post;

        public Worker(string name, string middlename, string surname, string post) : base(name, middlename, surname)
        {
            this.post = post;
        }

        public string Post
        {
            get
            {
                return (this.post);
            }
        }
    }
}
