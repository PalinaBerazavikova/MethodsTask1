using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(123.23, 4564.23);
            Point point1 = new Point(123.23, 4564.23);
            Point point2 = new Point(123, 4564);

            Console.WriteLine(point.Equals(point1));
            Console.WriteLine(point.Equals(point2));
            Console.WriteLine(point.ToString());
            Console.WriteLine(point2.ToString());
            Console.ReadKey();

        }
    }
}
