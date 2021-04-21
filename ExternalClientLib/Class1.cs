using System;

namespace ExternalClientLib
{
    public interface IGetArea                                           //Создаем интерфейс для метода, где мы будем искать прощадь наших фигур
    {
        double Area();
    }
    public class Triangle : IGetArea                                    //Создаем класс треугольника с 3 сторонами
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a = 0, double b = 0, double c = 0)       //Прописываем конструктор со сторонами в качестве аргументов
        {
            A = a;
            B = b;
            C = c;

            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) || Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) || Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2))
                Console.WriteLine("\nТреугольник прямоугольный.\n");    //Проверка прямоугольный ли треугольник
            else
                Console.WriteLine("\nТреугольник не прямоугольный.\n");

            if (A <= 0 || B <= 0 || C <= 0)                             //Проверка на нулевые значения сторон     
                throw new Exception("Одна из сторон треугольника меньше или равна нулю, такого треугольника не существует!");

            if (A + B < C || A + C < B || B + C < A)                    //Проверка на свойство треугольника, что сумма двух его сторон всегда должна быть больше третьей стороны 
                throw new Exception("Неверное соотношение сторон, такого треугольника не существует!");


        }

        public double Area()                                            //Метод для нахождения площади треугольника по трем его сторонам 
        {
            double p = (A + B + C) / 2;
            double S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            Console.WriteLine($"Площадь треугольника равна: {S}\n");
            return S;
        }
    }
    public class Circle : IGetArea                                      //Создаем аналогичный класс для круга, но с радиусом, а не тремя сторонами
    {
        public double R { get; set; }

        public Circle(double r = 0)
        {
            R = r;

            if (R <= 0)                                                 //Проверка на нулевое значение радиуса
                throw new Exception("Радиус круга меньше или равен нулю, такого круга не существует!");
        }
        public double Area()                                            //Метод для поиска площади круга
        {
            double S = Math.PI*Math.Pow(R, 2);
            Console.WriteLine($"Площадь круга равна: {S}\n");
            return S;
        }
    }
}