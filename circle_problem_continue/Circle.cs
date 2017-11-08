using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_first_project
{
    class Circle
    {
        double x = 1; //origin x coord
//        public int X { get; set; }
public double X
        {
            get { return x; }
            set { x = value; }
        }
double y = 2; //origin y coord
        public int Y { get; set; }
        double r = 10; //radius
        public int R { get; set; }
        public Circle(double newx, double newy, double newr)
        {
            x = newx; y = newy; r = newr;
        }
        public string print()
        {
            return "0(" + x + "," + y + ") r =" + r;
        }
        public bool inside(double x1, double y1)
        {
            return (x - x1) * (x - x1) + (y - y1) * (y - y1) < r * r;
        }
        public  double measuredist(double x1, double y1)
        {
            return (x - x1) * (x - x1) + (y - y1) * (y - y1);
        }
    }
}