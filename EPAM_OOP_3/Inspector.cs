using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_OOP_3
{
    public class Inspector
    {
        string Name { get; }
        

        public Inspector(string name)
        {
            Name = name; 
        }

        public void CheckSpeed(Driver driver)
        {
            if(driver.Speed > 60)
            {
                Offence(driver.Name, driver.Speed);
            }
            else
            {
                Console.WriteLine("Скорость в пределах нормы!");
            }
        }

        

        public delegate void DriverOffenceHandler(string name, int speed);
        public event DriverOffenceHandler Offence;
    }
}
