using System;

//20. Заданы М строк символов, которые вводятся с клавиатуры.
//    Найти количество символов в самой длинной строке.
//    Выровнять строки по самой длинной строке, поставив перед каждой строкой соответствующее количество звёздочек.

namespace Exercise_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = Input("Введите кол-во строк M: ");
            string[] lines = new string[m];
            int index = 0;
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"Введите {i + 1}-ю строку:");
                lines[i] = Console.ReadLine();
            }
            Console.WriteLine();
            for (int i = 1; i < m; i++)
                if (lines[i].Length > lines[index].Length)
                    index = i;

            for (int i = 0; i < m; i++)
            {
                if (i != index)
                {
                    string temp = "";
                    for (int j = 0; j < lines[index].Length - lines[i].Length; j++)
                        temp += "*";
                    lines[i] = string.Concat(temp, lines[i]);
                }
                Console.WriteLine(lines[i]);
            }
            Console.WriteLine();

        }

        static int Input(string message)
        {
            Console.Write(message);
            int num = 0;
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Вместо введенного значения будет возвращен ноль");
            }
            Console.WriteLine();
            return num;
        }
    }
}
