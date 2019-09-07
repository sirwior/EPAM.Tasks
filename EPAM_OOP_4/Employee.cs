using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_OOP_4
{
    class Employee
    {
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; set; }
        public List<Project> Projects;

        public Employee(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Projects = new List<Project>();
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
