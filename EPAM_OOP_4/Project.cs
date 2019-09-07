using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_OOP_4
{
    class Project
    {
        public string Name { get; }
        public DateTime StartDate { get; set; }
        public List<Employee> Employees;



        public Project(string name, DateTime startDate)
        {
            Name = name;
            StartDate = startDate;
            Employees = new List<Employee>();
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
