using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввести целочисленные координаты трех вершин прямоугольника, стороны которого параллельны координатным осям.
            // Найти координаты его четвертой вершины. Если пользователь введёт координаты точек так, что нельзя получить прямоугольник со сторонами,
            // параллельными координатным осям, вывести соответствующее сообщение.
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Координаты первой вершины A: {0}, {1}", x1, y1);
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Координаты второй вершины B: {0}, {1}", x2, y2);
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Координаты третьей вершины C: {0}, {1}", x3, y3);
            int x4 = 0;
            int y4 = 0;
            // bool verity = true;

            if (x1 == x2 && x1 != x3 && x2 != x3)
            {
                if (y1 == y3)
                {
                    x4 = x3;
                    y4 = y2;
                    Console.WriteLine("Тогда координаты четвёртой вершины D: {0}, {1} ", x4, y4);
                }
                else if (y2 == y3)
                {
                    x4 = x3;
                    y4 = y1;
                    Console.WriteLine("Тогда координаты четвёртой вершины D: {0}, {1} ", x4, y4);
                }
                else
                {
                    Console.WriteLine("Стороны прямоугольника не параллельны!");
                }
            }
            else if (x1 == x3 && x1 != x2 && x3 != x2)
            {
                if (y1 == y2)
                {
                    x4 = x2;
                    y4 = y3;
                    Console.WriteLine("Тогда координаты четвёртой вершины D: {0}, {1} ", x4, y4);
                }
                else if (y3 == y2)
                {
                    x4 = x3;
                    y4 = y1;
                    Console.WriteLine("Тогда координаты четвёртой вершины D: {0}, {1} ", x4, y4);
                }
                else
                {
                    Console.WriteLine("Стороны прямоугольника не параллельны!");
                }
            }
            else if (x2 == x3 && x2 != x1 && x3 != x1)
            {
                if (y2 == y1)
                {
                    x4 = x1;
                    y4 = y3;
                    Console.WriteLine("Тогда координаты четвёртой вершины D: {0}, {1} ", x4, y4);
                }
                else if (y3 == y1)
                {
                    x4 = x1;
                    y4 = y2;
                    Console.WriteLine("Тогда координаты четвёртой вершины D: {0}, {1} ", x4, y4);
                }
                else
                {
                    Console.WriteLine("Стороны прямоугольника не параллельны!");
                }
            }
            else if (x1 == x2 && x1 == x3 && x2 == x3)
            {
                if (y1 == y2 && y1 == y3 && y2 == y3)
                {
                    Console.WriteLine("Ошибка! Введены неверные координаты. Проверьте, правильность набора. ");
                }
                else
                {
                    Console.WriteLine("Ошибка! Введены неверные координаты. Невозможно построить прямоугольник");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Введены неверные координаты. Прямоугольник не параллелен осям OX и OY");
            }
            Console.ReadKey();
        }
    }
}
