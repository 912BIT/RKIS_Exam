using System;

//21. Заданы М строк слов, которые вводятся с клавиатуры.
//    Подсчитать количество гласных букв в каждой из заданных строк.

namespace Exercise_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = Input("Введите кол-во строк M: ");
            char[] arr = new char[10] { 'ё', 'у', 'е', 'ы', 'а', 'о', 'э', 'я', 'и', 'ю' };

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"Введите {i + 1}-ю строку:");
                string line = Console.ReadLine();
                int count = 0;
                for (int k = 0; k < line.Length; k++)
                {
                    for (int j = 0; j < 10; j++)
                        if (line[k] == arr[j])
                            count++;
                }

                Console.WriteLine($"В строке {count} гласных букв");
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
