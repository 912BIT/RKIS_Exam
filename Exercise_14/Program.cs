using System;

//14. Дано натуральное число. Определить будет ли это число: нечётным, кратным 5.

namespace Exercise_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Input("Введите число: ");
            Console.WriteLine();
            if (num > 0)
            {
                if (num % 2 != 0)
                    Console.WriteLine("Число нечётное");
                else Console.WriteLine("Число не является нечётным");
                if (num % 5 == 0)
                    Console.WriteLine("Число кратно пяти");
                else Console.WriteLine("Число не кратно пяти");
            }
            else Console.WriteLine("Введенное число не является натуральным");
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
