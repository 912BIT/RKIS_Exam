using System;

//16. Даны действительные числа: A, B, C.
//    Определить выполняются ли неравенства А<B<C или A>=B>=C и какое именно неравенство выполняется.

namespace Exercise_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Input("Введите A: ");
            int b = Input("Введите B: ");
            int c = Input("Введите C: ");
            Console.WriteLine();
            if (a < b && b < c)
                Console.WriteLine("Выполняется неравенство A < B < C");
            else if (a >= b && b >= c)
                Console.WriteLine("Выполняется неравенство A >= B >= C");
            else Console.WriteLine("Не одно из неравенств не выполняется");
            Console.ReadKey();
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
