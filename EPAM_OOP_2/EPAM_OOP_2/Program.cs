using System;
using System.Linq;

namespace EPAM_OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hare hare = new Hare();
            hare.AboutMe();
            hare.IAmRunObj();

            Duck duck = new Duck();
            duck.AboutMe();
            duck.IAmFlyObj();
            duck.IAmRunObj();
            duck.IAmSwimObj();

            Eagle eagle = new Eagle();
            eagle.AboutMe();
            eagle.IAmFlyObj();

            Plane plane = new Plane();
            plane.AboutMe();
            plane.IAmFlyObj();
            plane.IHaveEngine();

            Hen hen = new Hen();
            hen.AboutMe();
            hen.IAmFlyObj();
            hen.IAmRunObj();
            hen.IAmSwimObj();

            Powerboat powerboat = new Powerboat();
            powerboat.AboutMe();
            powerboat.IAmSwimObj();
            powerboat.IHaveEngine();

            //создать массивы: летающие объекты, плавающие объекты и вывести информацию о каждом на экран.

            Name[] names = { hare, hen, duck, eagle, powerboat, plane };

            var flyObj = from o in names
                         where o is IFlyObj
                         select o;

            var swimObj = from o in names
                         where o is ISwimObj
                         select o;

            Console.WriteLine("\nFly objects:");

            foreach (Name f in flyObj)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine("\nSwim objects:");

            foreach (Name s in swimObj)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
