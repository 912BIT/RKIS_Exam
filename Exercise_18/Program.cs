using System;

//18. Заданы М строк символов, которые вводятся с клавиатуры.
//    Из заданных строк, каждая из которых представляет одно слово, составить одну длинную строку, разделяя слова пробелами.
namespace Exercise_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = Input("Введите кол-во строк M: ");
            string message = "";
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"Введите {i + 1}-ю строку:");
                string line = Console.ReadLine();
                message += line + " ";
            }
            Console.WriteLine("Составленная строка:\n{0}", message);
            Console.ReadKey();
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
