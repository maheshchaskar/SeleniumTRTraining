using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept3
{
    public class Pogram3
    {
        public static int aS = 10;
        public static int bS = 20;

        public int aNS = 10;
        public int bNS = 20;

        static void Main(string[] args)
        {
            Pogram3.aS = 1000;

            Console.WriteLine(Pogram3.aS);
            Console.WriteLine(Pogram3.bS);

            Pogram3 obj1 = new Pogram3();
            Pogram3 obj2 = new Pogram3();

            obj1.aNS = 1000;

            Console.WriteLine(obj1.aNS);

            Console.WriteLine(obj2.aNS);
        }
    }
}
