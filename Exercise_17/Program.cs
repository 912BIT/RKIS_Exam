using System;

//17. Для вводимых чисел определить процент положительных и отрицательных чисел.
//    При вводе числа –65432 закончить работу.

namespace Exercise_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, posCount = 0, negCount = 0, count = 0;
            do
            {
                num = Input("Введите число: ");
                if (num > 0)
                    posCount++;
                else if (num < 0)
                    negCount++;
                count++;
            } while (num != -65432);
            Console.WriteLine();
            Console.WriteLine("Процент положительных чисел от общего количества: {0:F4}", (posCount * 100.0) / count);
            Console.WriteLine("Процент отрицательных чисел от общего количества: {0:F4}", (negCount * 100.0) / count);
            // count - 100 %
            // posCount - x
            // x = posCount * 100 / count
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
