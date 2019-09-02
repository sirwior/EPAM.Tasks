using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_OOP_3
{
    public class Driver
    {
        public string Name { get; }
        public int Speed { get; set; }

        public Driver(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }
    }
}
