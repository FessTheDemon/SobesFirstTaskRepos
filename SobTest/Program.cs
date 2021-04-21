using System;
using System.Collections.Generic;
using System.Linq;
using ExternalClientLib;

namespace SobTest
{
    class Program
    {
        static void GetArea(ExternalClientLib.IGetArea havearea)                                //Создаем метод для реализации метода Area из интерфейса IGetArea
        {
            havearea.Area();
        }
        static void Main(string[] args)
        {
            double r;                                                                           //Инициализируем переменную под радиус
            Console.WriteLine("Введите стороны треугольника через пробел: ");
            List<Double> numbers = Console.ReadLine().Split().Select(Double.Parse).ToList();    //Создаем список из вводимых через пробел значений 

            Triangle three = new Triangle(numbers[0], numbers[1], numbers[2]);                  //Создаем обьект нашего треугольника
            GetArea(three);                                                                     //Получаем площадь треугольника


            Console.WriteLine("Введите радиус круга: ");
            r = Convert.ToDouble(Console.ReadLine());                                           //Вводим значение радиуса круга с клавиатуры
            Circle circ = new Circle(r);                                                        //Создаем обьект нашего круга
            GetArea(circ);                                                                      //Получаем площадь круга

            Console.ReadKey();
        }
    }
}
