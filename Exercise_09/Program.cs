using System;

//9. Дан одномерный массив числовых значений, насчитывающий N элементов.Из элементов исходного массива построить два новых.
//    В первый должны входить только положительные элементы, а во второй только отрицательные элементы.
namespace Exercise_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[Input("Введите кол-во элементов N: ")];
            int[] posArr, negArr;
            int posCount = 0, negCount = 0;
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10, 10);
                if (arr[i] > 0) posCount++;
                else if (arr[i] < 0) negCount++;
                Console.Write(arr[i] + " ");
            }

            posArr = new int[posCount];
            negArr = new int[negCount];

            for (int i = 0, p = 0, n = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0) posArr[p++] = arr[i];
                else if (arr[i] < 0) negArr[n++] = arr[i];
            }

            Console.WriteLine("\nМассив из положительных элементов:");
            for (int i = 0; i < posArr.Length; i++)
                Console.Write(posArr[i] + " ");
            Console.WriteLine("\nМассив из отрицательных элементов:");
            for (int i = 0; i < negArr.Length; i++)
            {
                Console.Write(negArr[i] + " ");
            }
            Console.WriteLine();
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
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine("Вместо введенного значения будет возвращен ноль");
            }
            return num;
        }
    }
}
