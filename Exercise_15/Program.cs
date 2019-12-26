using System;

//15. Даны действительные числа: Х, Y, Z.
//    Определить существует ли треугольник с такими длинами сторон и, если существует, будет ли он прямоугольным.

namespace Exercise_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Input("Введите x: ");
            double y = Input("Введите y: ");
            double z = Input("Введите z: ");
            if (IsTriangle(x, y, z))
            {
                Console.WriteLine("Треугольник с введенными сторонами существует");
                if (AngleIsRectangle(x, y, z))
                    Console.WriteLine("Треугольник прямоугольный");
                else Console.WriteLine("Треугольник не прямоугольный");
            }
            else Console.WriteLine("Треугольника с введенными сторонами не существует");
            Console.ReadKey();
        }

        static bool AngleIsRectangle(double x ,double y, double z)
        {
            if (Math.Pow(z, 2) == Math.Pow(x, 2) + Math.Pow(y, 2) ||
                Math.Pow(x, 2) == Math.Pow(z, 2) + Math.Pow(y, 2) ||
                Math.Pow(y, 2) == Math.Pow(z, 2) + Math.Pow(x, 2))
                return true;
            return false;
        }
        static bool IsTriangle(double x, double y, double z)
        {
            if (x <= 0 || y <= 0 || z <= 0)
                return false;
            else if (x + y > z && x + z > y && y + z > x)
                return true;
            return false;
        }
        static int Input(string message)
        {
            int num = 0;
            Console.Write(message);
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine("Вместо введенного значения будет возвращен ноль");
            }
            return num;
        }
    }
}
