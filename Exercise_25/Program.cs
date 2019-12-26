using System;

//25. Известны длины трёх сторон треугольника.
//    Вычислить периметр треугольника и площадь по формуле Герона(указание: использовать библиотеку math и функцию sqrt()).

namespace Exercise_25
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Input("Введите x: ");
            double y = Input("Введите y: ");
            double z = Input("Введите z: ");
            Console.WriteLine();
            if (IsTriangle(x, y, z))
            {
                double p = x + y + z;
                double halfP = p / 2;
                Console.WriteLine($"Периметр треугольника: {p}\n" +
                                  $"Площадь треугольника по формуле Герона: {Math.Sqrt(halfP * (halfP - x) * (halfP - y) * (halfP - z))}");
            }
            else Console.WriteLine("Треугольника с введенными сторонами не существует");
        }

        static double Input(string message)
        {
            Console.Write(message);
            double num = 0.0;
            try
            {
                num = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine("Вместо введенного значения будет возвращен ноль");
            }
            return num;
        }
        static bool IsTriangle(double x, double y, double z)
        {
            if (x + y > z && x + z > y && y + z > x)
                return true;
            return false;
        }
    }
}
