using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_OOP_2
{
    class Hen : Name, IRunObj, IFlyObj, ISwimObj
    {
        public override string AboutMe()
        {
            return "I am Hen object";
        }

        public void IAmFlyObj()
        {
            Console.WriteLine("I can Fly");
        }

        public void IAmRunObj()
        {
            Console.WriteLine("I can Run");
        }

        public void IAmSwimObj()
        {
            Console.WriteLine("I can Swim");
        }

        public override string ToString()
        {
            return AboutMe();
        }
    }
}
