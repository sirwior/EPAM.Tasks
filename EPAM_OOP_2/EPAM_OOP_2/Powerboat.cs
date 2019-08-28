using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_OOP_2
{
    class Powerboat : Name, ISwimObj, IEngineObj
    {
        public override string AboutMe()
        {
            return "I am Powerboat object";
        }

        public void IAmSwimObj()
        {
            Console.WriteLine("I can Swim");
        }

        public void IHaveEngine()
        {
            Console.WriteLine("I have Engine");
        }

        public override string ToString()
        {
            return AboutMe();
        }
    }
}
