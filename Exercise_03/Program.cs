using System;

namespace Exercise_02
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n = Input("Введите N: ");
            int m = Input("Введите M: ");
            if (n < 0 || m < 0)
            {
                Console.WriteLine("Матрица не может иметь отрицательное количество строк или столбцов");
            }
            else
            {
                int[,] a = new int[n + 1, m];
                FillMatrix(ref a, n, m);
                ShowMatrix(ref a, n, m, "Матрица A:");
                AddRow(ref a, n + 1, m);
                ShowMatrix(ref a, n + 1, m, "Матрица A с добавленным столбцом с номером L:");
            }
        }

        static void ShowMatrix(ref int[,] matrix, int n, int m, string message)
        {
            Console.WriteLine("\n" + message);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void AddRow(ref int[,] matrix, int n, int m)
        {
            int l = Input("\nВведите L: ");
            if (l < 0 || l > n - 2)
            {
                Console.WriteLine("Номер L меньше нуля, либо больше кол-ва столбцов матрицы");
            }
            else
            {
                for (int i = n - 1; i > l; i--)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matrix[i, j] = matrix[i - 1, j];
                    }
                }
                for (int j = 0; j < m; j++)
                {
                    matrix[l, j] = Input($"Введите {j + 1}-й элемент нового столбца с номером L: ");
                }
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
                Console.WriteLine("Вместо заданного числа будет возвращен ноль");
            }
            return num;

        }
        static void FillMatrix(ref int[,] matrix, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rnd.Next(10);
                }
            }
        }
    }
}
