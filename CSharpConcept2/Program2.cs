using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationSolution;
using AutomationSolution.Formulae;

namespace CSharpConcept2
{
    internal class Program2
    {
       
        //public  static  double Area.AreaOfRectangle(10,5)
        //{
        //    return length * width;
        //}

        //public  static double   Area.AreaOfTriangle(10,5)
        //{
        //    return 0.5 * b * h;
        //}

        //public static double Area.AreaOfCircle(5);
        //{
        //    return 3.14* r*r;
        //}
   
        static void Main(String[] args)
        {
            int radius = 10;
            double area= 3.14* radius* radius;
            Console.WriteLine(area);

            double result2= Area.AreaOfCircle(5);
        Console.WriteLine(result2);

            double result = Area.AreaOfRectangle(10, 5);
        Console.WriteLine(result);

        //Load all non-static fields in memory
        Area obj = new Area();

           double result1= obj.AreaOfTriangle(10, 5);
            Console.WriteLine(0.5 * result1);

            //double result1=Program2 .AreaOfTriangle(10, 5);
            //Console.WriteLine(result1);
        }
    }
}
