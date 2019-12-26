using System;

//12. Дан одномерный массив числовых значений, насчитывающий N элементов.
//    Сумму элементов массива и количество положительных элементов поставить на первое и второе место.

namespace Exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[Input("Введите кол-во элементов N: ", true)];
            Random rnd = new Random();
            int sum = 0, posCount = 0;
            Console.WriteLine("Массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10, 10);
                if (arr[i] > 0) posCount++;
                sum += arr[i];
                Console.Write(arr[i] + " ");
            }

            if (arr.Length > 1)
            {
                arr[0] = sum;
                arr[1] = posCount;

            }

            Console.WriteLine("\nОбработанный массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();

        }

        static int Input(string message, bool zeroOrPos = false)
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
            if (zeroOrPos && num < 0)
            {
                Console.WriteLine("Введенное значение не может быть отрицательным, вместо него будет возвращен ноль");
                num = 0;
            }
            return num;
        }
    }
}
