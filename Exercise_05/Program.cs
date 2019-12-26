using System;

//5. Выполнить обработку элементов прямоугольной матрицы А, имеющей N строк и М столбцов.
//    Найти наибольшее значение среди средних значений для каждой строки матрицы.

namespace Exercise_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = Input("Введите кол-во строк N: "), m = Input("Введите кол-во столбцов M: ");
            int[,] a = new int[n, m];
            double[] sred = new double[n];
            Console.WriteLine("\nМатрица A:");
            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rnd.Next(10);
                    Console.Write(a[i, j] + " ");
                    sum += a[i, j];
                }
                if (m != 0)
                {
                    sum /= m;
                    sred[i] = sum;
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nСреднее значение для каждой строки:");
            for (int i = 0; i < n; i++)
                Console.WriteLine("{0}) {1:F3}", i,sred[i]);
            Array.Sort(sred);
            Console.WriteLine("\nНаибольшее значение среди средних значений строк матрицы A: {0:F3}", sred[n - 1]);
            Console.ReadKey();
        }

        static int Input(string message)
        {
            Console.Write(message);
            int num;
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine("Вместо введеного значения будет возвращен ноль");
                num = 0;
            }
            return num;
        }
    }
}
