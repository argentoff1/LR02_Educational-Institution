using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    public class Group
    {
        private string namegroup;
        private Teacher teacher;
        private List<Student> students = new List<Student>();

        public void SetTeacher(Teacher teacher)
        {
            teacher.SetGroup(this);
            this.teacher = teacher;
        }
        public void AddStudent(Student student)
        {
            this.students.Add(student);
            student.group = this;
        }

        public string NameGroup
        {
            get
            {
                return (namegroup);
            }
            set
            {
                this.namegroup = value;
                foreach (Student student in students) student.group = this;
            }
        }
        public int GetNumber()
        {
            return (this.students.Count);
        }
        public void UpData()
        {
            try
            {
                foreach (Student student in students)
                {
                    if (student.studies == false) students.Remove(student);
                }
            }
            catch {}
        }
        public List<Student> GroupList()
        {
            return (this.students);
        }
    }
}
