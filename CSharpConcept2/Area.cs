using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSolution.Formulae
{
    public class Area
    {
        public static double AreaOfRectangle(double length, double width)
        {
            return length * width;
        }

        public double AreaOfTriangle(double b, double h)
        {
            return 0.5 * b * h;
        }

        public static double AreaOfCircle(double r)
        {
            return 3.14 * r * r;
        }
    }
}
