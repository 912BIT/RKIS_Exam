using System;

//10. Дан одномерный массив числовых значений, насчитывающий N элементов.Исключить из массива элементы, принадлежащие промежутку[В;С].

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Input("Введите кол-во элементов N: ");
            if (n >= 0)
            {
                Random rnd = new Random();
                int[] arr = new int[n];
                int b = Input("Введите B: ");
                int c = Input("Введите C: ");
                Console.WriteLine("\nМассив:");
                int exclude = 0;
                for (int i = 0; i < n; i++)
                {
                    arr[i] = rnd.Next(-10, 10);
                    if (arr[i] >= b && arr[i] <= c)
                        exclude++;
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine("\nМассив с исключенным элементами:");
                int[] newArr = new int[n - exclude];
                for (int i = 0, j = 0; i < n; i++)
                {
                    if (arr[i] < b || arr[i] > c)
                    {
                        newArr[j] = arr[i];
                        Console.Write(newArr[j++] + " ");
                    }
                }
                Console.WriteLine();
            }
            else Console.WriteLine("Кол-во элементов N не может быть отрицательным");
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
