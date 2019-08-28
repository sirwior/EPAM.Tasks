using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_OOP_2
{
    class Eagle : Name, IFlyObj
    {
        public override string AboutMe()
        {
            return "I am Eagle object";

        }

        public void IAmFlyObj()
        {
            Console.WriteLine("I can Fly");
        }

        public override string ToString()
        {
            return AboutMe();
        }
    }
}
