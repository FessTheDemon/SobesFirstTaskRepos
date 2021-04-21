using System;
using ExternalClientLib;

namespace SobTest
{
    class Program
    {
        static void GetArea(ExternalClientLib.IGetArea havearea)
        {
            havearea.Area();
        }
        static void Main(string[] args)
        {
            double a, b, c, r;
            Console.WriteLine("Введите стороны треугольника: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            Triangle three = new Triangle(a, b, c);
            GetArea(three);


            Console.WriteLine("Введите радиус круга: ");
            r = Convert.ToDouble(Console.ReadLine());
            Circle circ = new Circle(r);
            GetArea(circ);

            Console.ReadKey();
        }
    }
}
