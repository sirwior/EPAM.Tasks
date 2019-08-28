using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_OOP_2
{
    class Hare : Name, IRunObj
    {
        public override string AboutMe()
        {
            return "I am Hare object";
        }

        public void IAmRunObj()
        {
            Console.WriteLine("I can Run");
        }

        public override string ToString()
        {
            return AboutMe();
        }
    }
}
