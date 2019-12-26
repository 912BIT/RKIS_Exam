using System;

//7. Дан одномерный массив числовых значений, насчитывающий N элементов.
//    Добавить к элементам массива такой новый элемент, 
//    чтобы сумма положительных элементов стала бы равна модулю суммы отрицательных элементов.
namespace Exercise_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Input("Введите кол-во элементов N: ");
            if (n < 0)
            {
                Console.WriteLine("Кол-во элементов массива не может быть отрицательным");
            }
            else
            { 
                int[] arr = new int[n + 1];
                Random rnd = new Random();
                Console.WriteLine("Массив:");
                int sumPositive = 0, sumNegative = 0;
                for (int i = 0; i < n; i++)
                {
                    arr[i] = rnd.Next(10) - 5;
                    if (arr[i] > 0)
                        sumPositive += arr[i];
                    else if (arr[i] < 0) sumNegative += arr[i];
                    Console.Write(arr[i] + " ");
                }

                sumNegative = Math.Abs(sumNegative);
                if (sumPositive <= sumNegative)
                    arr[n] = sumNegative - sumPositive;
                else if (sumPositive > sumNegative)
                    arr[n] = sumPositive - sumNegative;
                Console.WriteLine("\nОбработанный массив:");
                for (int i = 0; i < n + 1; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
}

        static int Input(string message)
        {
            int num;
            Console.Write(message);
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine("Вместо введенного значения будет возвращен ноль");
                num = 0;
            }
            return num;
        }
    }
}
