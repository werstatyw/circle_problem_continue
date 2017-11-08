using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_first_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(1, 2, 10);
            Circle c2 = new Circle(3, 4, 15);
            Console.WriteLine(c1.print());
            Console.WriteLine("(2,4) " + c1.inside(2, 4) + " " + c2.inside(2, 4));
            c1.X = 1.2;
            Console.WriteLine(c1.X);
            Console.WriteLine(c2.print());
            Console.WriteLine("(1,2) " + c1.inside(1, 2) + " " + c2.inside(1, 2));
            Console.WriteLine(c1.X);
            Console.WriteLine("distance is " + c1.measuredist(1, 2) + " " + c2.measuredist(1, 2));
            Console.WriteLine("The end.");
            Console.ReadKey();
        }
    }
}