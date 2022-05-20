using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    public class PersonnelOfficer : Worker
    {
        public PersonnelOfficer(string name, string middlename, string surname)
            : base(name, middlename, surname, "Кадровик") { }
        public void AddStudent(Group group, Student student)
        {
            group.AddStudent(student);
        }
        public Student MakeStudent(string name, string middlename, string surname)
        {
            return (new Student(name, middlename, surname));
        }
        public Teacher MakeTeacher(string name, string middlename, string surname)
        {
            return (new Teacher(name, middlename, surname));
        }
        public Group MakeGroup()
        {
            return (new Group());
        }
    }
}
