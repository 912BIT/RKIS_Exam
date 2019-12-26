using System;

//4. Выполнить обработку элементов прямоугольной матрицы А, имеющей N строк
//    и М столбцов. Исходная матрица состоит из нулей и единиц.
//    Добавить к матрице еще один столбец, каждый элемент которого 
//    делает количество единиц в каждой строке четным.

namespace Exercise_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] a = new int[Input("Введите N: "), Input("Введите M: ") + 1];
            Console.WriteLine("\nМатрица A:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < a.GetLength(1) - 1; j++)
                {
                    a[i, j] = rnd.Next(2); //заполнение матрицы
                    Console.Write(a[i, j] + " "); //вывод элементов матрицы
                    sum += a[i, j]; //сложение всех элементов в текущей строке
                }
                //если сумма в пройденной строке нечетна добавить в конец строки элемент равный 1
                if (sum % 2 != 0)
                {
                    a[i, a.GetLength(1) - 1] = 1;
                }
                //иначе добавить элемент равны 0
                else a[i, a.GetLength(1) - 1] = 0;
                sum = 0;
                Console.WriteLine();
            }
            Console.WriteLine("\nОбработанная матрица A:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
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
                Console.WriteLine("Вместо введеного значения будет возвращен ноль");
                num = 0;
            }

            return num;
        }
    }
}
