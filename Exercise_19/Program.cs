using System;

//19. Заданы М строк символов, которые вводятся с клавиатуры.
//    Каждая строка представляет собой последовательность символов, включающих в себя вопросительные знаки.
//    Заменить в каждой строке все имеющиеся вопросительные знаки звёздочками.

namespace Exercise_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = Input("Введите кол-во строк M: ");
            string[] lines = new string[m];
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"Введите {i + 1}-ю строку:");
                lines[i] = Console.ReadLine();
                lines[i] = lines[i].Replace('?', '*');
            }
            Console.WriteLine();
            for (int i = 0; i < m; i++)
                Console.WriteLine($"{i + 1})" + lines[i]);
            Console.ReadKey();
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
