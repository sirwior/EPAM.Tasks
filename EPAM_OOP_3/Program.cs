using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_OOP_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver("Oleg", 70);
            Inspector inspector = new Inspector("Sanya");
            inspector.Offence += Penalty;
            inspector.CheckSpeed(driver);

            Console.ReadLine();

            
        }

        private static void Penalty(string nameViolator, int speed)
        {
            if ((speed - 60) <= 10 && (speed - 60) > 0)
            {
                Console.WriteLine($"{nameViolator} оштрафован на 100 грн.");
            }
            if ((speed - 60) <= 20 && (speed - 60) > 10)
            {
                Console.WriteLine($"{nameViolator} оштрафован на 200 грн.");
            }
            if (speed - 60 > 20)
            {
                Console.WriteLine($"{nameViolator} оштрафован на 500 грн.");          
            }
        }
    }
}
