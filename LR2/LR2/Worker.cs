using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class Worker : Person
    {
        public string position;

        public void GetPosition()
        {
            Console.WriteLine($"Должность: {this.position}");
        }
    }
}
