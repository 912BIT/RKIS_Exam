using System;

//30. Определить сумму вводимых положительных чисел.
//    Причём числа с нечётными номерами суммировать с обратным знаком, а числа с чётными номерами перед суммированием возводить в квадрат.
//    Подсчитать количество слагаемых. При вводе первого отрицательного числа закончить работу.

namespace Exercise_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = -1, even = -1;
            double sum = 0;
            Console.WriteLine("Введите числа:");
            do
            {
                try
                {
                    Console.Write("{0} число: ", even + 1);
                    num = Convert.ToInt32(Console.ReadLine());
                    even++;
                    if (num > 0)
                    {
                        if (even % 2 == 0)
                            sum += Math.Pow(num, 2);
                        else sum += -num;
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            } while (num >= 0);
            Console.WriteLine("Сумма: {0}", sum);
            Console.ReadKey();
        }
    }
}
