using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_OOP_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ITCompany company = new ITCompany("EPAM");

            Employee programmer = new Employee("Вася","Иванов", 25);
            Employee lawyer = new Employee("Альберт", "Лермонотов", 27);
            Employee engineer = new Employee("Георгий", "Чехов", 20);
            Employee boss = new Employee("Артём", "Достоевский", 45);
            Employee worker1 = new Employee("Иван", "Гоголь", 18);
            Employee worker2 = new Employee("Алёна", "Франко", 34);
            Employee worker3 = new Employee("Алина", "Шевченко", 22);
            Employee worker4 = new Employee("Евгений", "Горький", 50);
            Employee worker5 = new Employee("Сергей", "Бунин", 31);
            Employee worker6 = new Employee("Никита", "Гюго", 29);
            Employee worker7 = new Employee("Антон", "Гёте", 19);
            Employee worker8 = new Employee("Альберт", "Энштейн", 29);

            Project project1 = new Project("Сайт", new DateTime(2016, 5, 28));
            Project project2 = new Project("БД", new DateTime(2018, 5, 18));
            Project project3 = new Project("Игра", new DateTime(2019, 2, 10));
            Project project4 = new Project("Мессенджер", new DateTime(2016, 5, 28));

            project1.Employees.Add(programmer);
            project1.Employees.Add(engineer);
            project1.Employees.Add(boss);
            project1.Employees.Add(worker5);
            project1.Employees.Add(worker6);
            project1.Employees.Add(worker2);
            
            project2.Employees.Add(programmer);
            project2.Employees.Add(engineer);
            project2.Employees.Add(lawyer);
            project2.Employees.Add(worker1);
            project2.Employees.Add(worker2);
            project2.Employees.Add(worker3);
            project2.Employees.Add(worker4);

            
            project3.Employees.Add(worker1);
            project3.Employees.Add(worker3);
            project3.Employees.Add(worker7);
            project3.Employees.Add(worker8);

            project4.Employees.Add(programmer);
            project4.Employees.Add(engineer);
            project4.Employees.Add(boss);
            project4.Employees.Add(worker5);
            project4.Employees.Add(worker6);
            project4.Employees.Add(worker1);
            project4.Employees.Add(worker2);
            project4.Employees.Add(worker3);

            programmer.Projects.Add(project1);
            programmer.Projects.Add(project2);
            programmer.Projects.Add(project4);

            engineer.Projects.Add(project1);
            engineer.Projects.Add(project2);
            engineer.Projects.Add(project4);

            boss.Projects.Add(project1);
            boss.Projects.Add(project4);

            worker1.Projects.Add(project2);
            worker1.Projects.Add(project3);
            worker1.Projects.Add(project4);

            worker2.Projects.Add(project1);
            worker2.Projects.Add(project2);
            worker2.Projects.Add(project4);

            worker3.Projects.Add(project2);
            worker3.Projects.Add(project3);
            worker3.Projects.Add(project4);

            worker4.Projects.Add(project2);

            worker5.Projects.Add(project1);
            worker5.Projects.Add(project4);

            worker6.Projects.Add(project1);
            worker6.Projects.Add(project4);

            worker7.Projects.Add(project3);

            worker8.Projects.Add(project3);


            company.Employees.Add(programmer);
            company.Employees.Add(lawyer);
            company.Employees.Add(engineer);
            company.Employees.Add(boss);
            company.Employees.Add(worker1);
            company.Employees.Add(worker2);
            company.Employees.Add(worker3);
            company.Employees.Add(worker4);
            company.Employees.Add(worker5);
            company.Employees.Add(worker6);
            company.Employees.Add(worker7);
            company.Employees.Add(worker8);


            company.Projects.Add(project1);
            company.Projects.Add(project2);
            company.Projects.Add(project3);
            company.Projects.Add(project4);

            
            company.GetEmployees();
            
            company.GetProjectsFromDate(new DateTime(2018, 2, 1));

            int num = company.NumberYoungProjects();
            Console.WriteLine($"\nКоличество проектов, которые длятся не больше года и сотрудники которых не старше 30 лет: \n {num}");

            string surname = company.GetOlderEmployee();
            Console.WriteLine($"\nФамилия самого старого работника, \nкоторый работает только на одном проекте стартовавшем в этом году: {surname}");


            Console.ReadLine();
        }
    }
}
