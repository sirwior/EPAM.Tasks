using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_OOP_4
{
    class ITCompany
    {
        public string Name { get; }
        public List<Employee> Employees;
        public List<Project> Projects;

        public ITCompany(string name)
        {
            Name = name;
            Employees = new List<Employee>();
            Projects = new List<Project>();
        }

        public void GetEmployees()
        {
            var employees = (from employee in Employees
                            where employee.Projects.Count > 1
                            orderby employee.Name
                            select employee).ToList();

            Console.WriteLine("\nСотрудники, работающие на двух и более проектах(в алфавитном порядке):\n");

            foreach (var emp in employees)
            {
                Console.WriteLine(emp);
            }
        }

        public void GetProjectsFromDate(DateTime date)
        {
            var projects = (from project in Projects
                           where project.StartDate > date
                           orderby project.StartDate
                           select project).ToList();

            Console.WriteLine($"\nПроекты, которые начинаются не раньше {date}:\n");

            foreach (var proj in projects)
            {
                Console.WriteLine(proj);
            }
        }

        public int NumberYoungProjects()
        {

            var cou = (from pr in Projects
                       where (DateTime.Now - pr.StartDate).TotalDays <= 365
                       select pr
                       into proj
                       where proj.Employees.TrueForAll(x => x.Age <= 30)
                       select proj
                       ).Count();
            return cou;
        }
        public string GetOlderEmployee()
        {
            var employee = (from emp in Employees
                            where emp.Projects.Count == 1
                            select emp
                           into empl
                            where empl.Projects.TrueForAll(x => x.StartDate.Year == 2019)
                            orderby empl.Age descending 
                            select empl).ToList();
            return employee[0].Surname;
        }

    }
}
