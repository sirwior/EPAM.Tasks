using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_OOP_2
{
    class Plane : Name, IFlyObj, IEngineObj
    {
        public override string AboutMe()
        {
            return "I am Plane object";

        }

        public void IAmFlyObj()
        {
            Console.WriteLine("I can Fly");
        }

        public void IHaveEngine()
        {
            Console.WriteLine("I nave Engine");
        }

        public override string ToString()
        {
            return AboutMe();
        }
    }
}
