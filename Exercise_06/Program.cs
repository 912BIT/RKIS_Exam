using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[Input("Введите кол-во строк N: "), Input("Введите кол-во столбцов M: ")];
            Random rnd = new Random();
            Console.WriteLine("\nМатрица A:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rnd.Next(10);
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            int k = Input("\nВведите номер столбца K: ");
            Console.WriteLine("\nОбработанная матрица A:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int multi = a[i, k];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] *= multi;
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
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
                Console.WriteLine("Вместо введеного значения будет возвращен ноль");
            }
            finally
            {
                if (num < 0)
                {
                    Console.WriteLine("Введенное значение меньше нуля");
                    Console.WriteLine("Вместо введеного значения будет возвращен ноль");
                    num = 0;
                }
            }
            return num;
        }
    }
}
