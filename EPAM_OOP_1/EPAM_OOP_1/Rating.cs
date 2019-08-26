using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_OOP_1
{
    class Rating
    {
        public List<Student> Students;

        public Rating()
        {
            Students = new List<Student> { };
        }

        public void Add(Student student)
        {
            if(Students.Count != 0)
            {
                bool cont = false;

                for (int i = 0; i < Students.Count; i++)
                {
                    if (Students[i].Name == student.Name && Students[i].Mark == student.Mark)
                    {
                        cont = true;
                    }
                }
                if (cont != true)
                {
                    Students.Add(student);

                    var students = from studen in Students
                                   orderby studen.Mark descending, studen.Name
                                   select studen;
                    Students = students.ToList();
                }
                
            }
            else
            {
                Students.Add(student);
            }
        }

        public void Print()
        {
            foreach (Student student in Students)
                Console.WriteLine(student.Name + " " + student.Mark);
        }
    }
}
