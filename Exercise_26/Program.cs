using System;

//26. Имеется коробка со сторонами: АхВхС. Определить пройдёт ли она в дверь с размерами МхК

namespace Exercise_26
{
    class Program
    {
        static void Main(string[] args)
        {
            //3! = 6;
            //ABC
            //ACB
            //BAC
            //BCA
            //CAB
            //CBA

            Console.WriteLine("Введите стороны коробки:");
            double a = Input("Введите A: ");
            double b = Input("Введите B: ");
            double c = Input("Введите C: ");
            Console.WriteLine("\nВведите размеры двери:");
            double m = Input("Введите M: ");
            double k = Input("Введите K: ");
            Console.WriteLine();
            double door = m * k;
            if (a * b <= door || a * c <= door || b * a <= door || b * c <= door || c * a <= door || c * b <= door)
                Console.WriteLine("Коробка пройдет в дверь");
            else Console.WriteLine("Коробка не пройдет в дверь");
            Console.ReadKey();



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
    }
}
