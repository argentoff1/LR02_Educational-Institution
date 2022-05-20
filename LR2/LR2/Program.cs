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
            PersonnelOfficer personnelOfficer = new PersonnelOfficer("Иван", "Васильевич", "Дьяков");
            Student firstStudent = personnelOfficer.MakeStudent("Илья", "Александрович", "Иванов");
            Student secondStudent = personnelOfficer.MakeStudent("Василий", "Иванович", "Александров");
            Student thirdStudent = personnelOfficer.MakeStudent("Александр", "Александрович", "Судентовский");
            Teacher teacher = personnelOfficer.MakeTeacher("Сергей", "Алексеевич", "Осокин");

            Group group = personnelOfficer.MakeGroup();
            group.SetTeacher(teacher);
            teacher.Lecture = 23;
            teacher.Lectured();
            group.NameGroup = "2-1Г9";
            group.AddStudent(firstStudent);
            group.AddStudent(secondStudent);
            group.AddStudent(thirdStudent);

            Console.WriteLine(personnelOfficer.GetAllFullName());
            Console.WriteLine(teacher.GetAllFullName());
            Console.WriteLine(thirdStudent.GetAllFullName());

            Console.WriteLine(thirdStudent.GetGroup());
            Console.WriteLine(personnelOfficer.Post);
            Console.WriteLine(teacher.Post);
            Console.WriteLine(group.GetNumber());
            secondStudent.Deducted();
            Console.WriteLine(group.GetNumber());
            Console.WriteLine(teacher.Lecture);
            teacher.Lectured();
            Console.WriteLine(teacher.Lecture);
        }
    }
}
