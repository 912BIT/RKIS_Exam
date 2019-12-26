using System;

namespace Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Введите N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите M: ");
            int m = Convert.ToInt32(Console.ReadLine());
            if (n < 0 || m < 0)
            {
                Console.WriteLine("\nНомер строки или столбца не может быть отрицательным");
            }
            else
            {
                Console.WriteLine("\nМатрица A:");
                int[,] a = new int[n, m];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        a[i, j] = rnd.Next(10);
                        Console.Write(a[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Введите номер строки L: ");
                int l = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите номер столбца K: ");
                int k = Convert.ToInt32(Console.ReadLine());
                if (l < 0 || l > n - 1 || k < 0 || k > m - 1)
                {
                    Console.WriteLine("Номеры L и K не указывают на какой-либо элемент матрицы A");
                }
                else if (l == 0 || l == n - 1 || k == 0 || k == m - 1)
                {
                    Console.WriteLine("Введенные L и K не поделят матрицу на 4 части");
                }
                else
                {
                    int startI = 0, startJ = 0, endI = 0, endJ = 0;
                    double sred, count;
                    for (int p = 0; p < 4; p++)
                    {
                        sred = 0;
                        count = 0;
                        switch (p)
                        {
                            case 0:
                                startI = 0; startJ = 0;
                                endI = l; endJ = k;
                                break;
                            case 1:
                                startI = 0; startJ = k + 1;
                                endI = l; endJ = m;
                                break;
                            case 2:
                                startI = l + 1; startJ = 0;
                                endI = n; endJ = k;
                                break;
                            case 3:
                                startI = l + 1; startJ = k + 1;
                                endI = n; endJ = m;
                                break;
                        }

                        Console.WriteLine($"\n{p + 1} часть:");
                        for (int i = startI; i < endI; i++)
                        {
                            for (int j= startJ; j < endJ; j++)
                            {
                                Console.Write(a[i, j] + " ");
                                sred += a[i, j];
                                count++;
                            }
                            if (count == 0)
                                i = l;
                            else
                                Console.WriteLine();
                        }

                        if (count == 0) count = 1;
                        Console.WriteLine($"Среднее {p + 1} части: " + sred / count);
                    }

                }
            }
        }
    }
}
