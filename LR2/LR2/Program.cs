using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher ("Бузмэков Александр Михайлович", "Преподаватель");
            teacher.GetFullName();
            teacher.GetPosition();
            Console.WriteLine();

            PersonnelOfficer personnelOfficer = new PersonnelOfficer("Андреев Андрей Андреевич", "Кадровик");
            personnelOfficer.GetFullName();
            personnelOfficer.GetPosition();
            Console.WriteLine();

            Student student = new Student("МуRATов Матвей Сергеевич", "2-1П11");
            student.GetFullName();
            student.GetGroup();
            Console.WriteLine();


        }
    }
}
