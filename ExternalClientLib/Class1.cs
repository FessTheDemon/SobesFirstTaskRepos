using System;

namespace ExternalClientLib
{
    public interface IGetArea
    {
        double Area();
    }
    public class Triangle : IGetArea
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a = 0, double b = 0, double c = 0)
        {
            A = a;
            B = b;
            C = c;

            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) || Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) || Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2))
                Console.WriteLine("\nТреугольник прямоугольный.\n");
            else
                Console.WriteLine("\nТреугольник не прямоугольный.\n");

            if (A <= 0 || B <= 0 || C <= 0)
                throw new Exception("Одна из сторон треугольника меньше или равна нулю, такого треугольника не существует!");

            if (A + B < C || A + C < B || B + C < A)
                throw new Exception("Неверное соотношение сторон, такого треугольника не существует!");


        }

        public double Area()
        {
            double p = (A + B + C) / 2;
            double S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            Console.WriteLine($"Площадь треугольника равна: {S}\n");
            return S;
        }
    }
    public class Circle : IGetArea
    {
        public double R { get; set; }

        public Circle(double r = 0)
        {
            R = r;

            if (R <= 0)
                throw new Exception("Радиус круга меньше или равен нулю, такого круга не существует!");
        }
        public double Area()
        {
            double S = Math.PI*Math.Pow(R, 2);
            Console.WriteLine($"Площадь круга равна: {S}\n");
            return S;
        }
    }
}