using System;

//13. Дано действительное число А.Вычислить f(A), если f(x)= x2 + 4x+5, при x<=2; в противном случае f(x)=1/(x2+4x+5).

namespace Exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("f(a) = {0}",Func(Input("Введите A: ")));
            Console.ReadKey();
        }

        static double Func(double x)
        {
            double res = Math.Pow(x, 2) + 4.0 * x + 5.0;
            if (x <= 2)
                return res;
            return Math.Pow(res, -1);
        }

        static double Input(string message)
        {
            double num = 0.0;
            Console.Write(message);
            try
            {
                num = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine("Вместо введенного значения будет возвращен 0");
            }
            return num;
        }
    }
}
