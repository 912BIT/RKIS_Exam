using System;

//8. Дан одномерный массив числовых значений, насчитывающий N элементов. 
//Добавить столько элементов, чтобы положительных и отрицательных стало бы поровну.

namespace Exercise_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[Input("Введите кол-во элементов N: ")];
            int posCount = 0, negCount = 0;
            Random rnd = new Random();
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(10) - 5;
                if (arr[i] > 0) posCount++;
                else if (arr[i] < 0) negCount++;
                Console.Write(arr[i] + " ");
            }

            int elCount = 0;
            bool pos = false, createArr = false;
            if (posCount < negCount)
            {
                elCount = negCount - posCount;
                pos = true;
                createArr = true;
            }
            else if (posCount > negCount)
            {
                elCount = posCount - negCount;
                pos = false;
                createArr = true;
            }

            if (createArr)
            {
                int[] newArr = new int[arr.Length + elCount];
                Array.Copy(arr, 0, newArr, 0, arr.Length);
                for (int i = arr.Length; i < newArr.Length; i++)
                {
                    if (pos)
                        newArr[i] = rnd.Next(1, 5);
                    else newArr[i] = rnd.Next(-5, -1);
                }
                arr = newArr;
            }

            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

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
