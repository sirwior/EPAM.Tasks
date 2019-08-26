using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_OOP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rating rating = new Rating();

            rating.Add(new Student("Павлов", 50));
            rating.Add(new Student("Рязанцев", 20));
            rating.Add(new Student("Скляр", 50));
            rating.Add(new Student("Артёмов", 100));
            rating.Add(new Student("Артёмов", 40));
            rating.Add(new Student("Рязанцев", 20));

            rating.Print();
            Console.ReadLine();

        }
    }
}
