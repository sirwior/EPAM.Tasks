using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_OOP_1
{
    public class Student
    {
        public string Name { get; set; }
        public int Mark { get; set; }

        public Student(string name, int mark)
        {
            Name = name;
            Mark = mark;
        }
    }
}
