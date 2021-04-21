using System;
using System.Collections.Generic;
using System.Linq;
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
            double r;
            Console.WriteLine("Введите стороны треугольника через пробел: ");
            List<Double> numbers = Console.ReadLine().Split().Select(Double.Parse).ToList();

            Triangle three = new Triangle(numbers[0], numbers[1], numbers[2]);
            GetArea(three);


            Console.WriteLine("Введите радиус круга: ");
            r = Convert.ToDouble(Console.ReadLine());
            Circle circ = new Circle(r);
            GetArea(circ);

            Console.ReadKey();
        }
    }
}
