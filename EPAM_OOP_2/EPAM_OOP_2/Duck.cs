using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_OOP_2
{
    class Duck : Name, IRunObj, ISwimObj, IFlyObj
    {
        public override string AboutMe()
        {
            return "I am Duck object";

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
