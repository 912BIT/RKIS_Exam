using System;

//23. Известен ГОД.Определить будет ли этот год високосным, и к какому веку этот год относится.

namespace Exercise_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год:");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine("Високосный");
            }
            else if (year % 100 == 0 && year % 400 == 0)
            {
                Console.WriteLine("Високосный");
            }
            else Console.WriteLine("Не является високосным");
            Console.WriteLine("Век: {0}", (year / 100) + 1);


        }
    }
}
