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
                int[,] a = new int[n, m + 1];
                FillMatrix(ref a, n, m);
                ShowMatrix(ref a, n, m, "Матрица A:");
                AddColumn(ref a, n, m + 1);
                ShowMatrix(ref a, n, m + 1, "Матрица A с добавленным столбцом с номером L:");
            }
        }

        static void ShowMatrix(ref int[,] matrix, int n, int m, string message)
        {
            Console.WriteLine("\n"+message);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void AddColumn(ref int[,] matrix, int n, int m)
        {
            int l = Input("\nВведите L: ");
            if (l < 0 || l > m - 2)
            {
                Console.WriteLine("Номер L меньше нуля, либо больше кол-ва столбцов матрицы");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = m - 1; j > l; j--)
                    {
                        matrix[i, j] = matrix[i, j - 1];
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    matrix[i, l] = Input($"Введите {i + 1}-й элемент нового столбца с номером L: ");
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
