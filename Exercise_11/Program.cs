using System;
//11. Дан одномерный массив числовых значений, насчитывающий N элементов.
//    Поменять местами элементы, стоящие на чётных и нечётных местах: А(1) с А(2), А(3) с А(4) …

namespace Exercise_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Input("Введите кол-во элементов N: ");
            if (n >= 0)
            {
                int[] arr = new int[n];
                Random rnd = new Random();
                Console.WriteLine("\nМассив:");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = rnd.Next(-10, 10);
                    Console.Write(arr[i] + " ");
                }
                for (int i = 0; i < n - 1; i += 2)
                {
                    int temp = arr[i + 1];
                    arr[i + 1] = arr[i];
                    arr[i] = temp;
                }

                Console.WriteLine("\nОбработанный массив:");
                for (int i = 0; i < n; i++)
                    Console.Write(arr[i] + " ");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Кол-во элементов не может быть отрицательным");
            }
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Вместо введенного значения будет возвращен ноль");
            }
            return num;
        }
    }
}
