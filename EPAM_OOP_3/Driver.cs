using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_OOP_3
{
    public class Driver
    {
        public delegate void DriverOffenceHandler(string driverName, int speed, string inspectorName);
        public event DriverOffenceHandler Offence;

        public string Name { get; }
        public int Speed { get; set; }

        public Driver(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        public void CheckSpeed(Inspector inspector)
        {

            if (this.Speed > 60)
            {
                Offence(this.Name, this.Speed, inspector.Name);
            }
            else
            {
                Console.WriteLine("Скорость в пределах нормы!");
            }
        }
    }
}
