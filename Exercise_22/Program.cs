using System;

//22. Заданы М строк слов, которые вводятся с клавиатуры.
//    Подсчитать количество пробелов в каждой из строк.

namespace Exercise_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = Input("Введите m: ");
            string[] arr = new string[m];
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"Введите {i + 1}-ю строку:");
                arr[i] = Console.ReadLine();
            }
            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                int space = 0;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (char.IsWhiteSpace(arr[i][j]))
                        space++;
                }
                Console.WriteLine($"В {i + 1} строке {space} пробелов");
            }
            
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
