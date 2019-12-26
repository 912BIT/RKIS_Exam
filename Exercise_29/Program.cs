using System;

//29. Можно ли в квадратном зале площадью S поместить круглую сцену радиусом R так, чтобы от стены до сцены был проход не менее К?

namespace Exercise_29
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = Input("Введите площадь S: ");
            double r = Input("Введите радиус R: ");
            double k = Input("Введите K: ");

            if (s < 0 || r < 0 || k < 0)
            {
                Console.WriteLine("Геометрические величины не могут быть отрицательными");
            }
            else
            {
                //поместиться ли сцена вообще в квадрат
                if (2 * r <= Math.Sqrt(s))
                {
                    //проход больше, либо равен k
                    if ((Math.Sqrt(2 * s) - 2 * r) / 2 >= k)
                        Console.WriteLine("Круглую сцену можно поместить в квадратный зал, чтобы проход от стены до сцены был не менее K");
                }
                else Console.WriteLine("Круглая сцена больше квадратного зала");
            }
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
