using System;

//28. Имеются две ёмкости: кубическая с ребром А, цилиндрическая с высотой Н и радиусом основания R.
//    Определить поместится ли жидкость объёма М в первую ёмкость, во вторую, в обе.

namespace Exercise_28
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Input("Введите ребро кубической ёмкости A: ");
            double h = Input("Введите высоту цилиндрической ёмкости H: ");
            double r = Input("Введите радуис основания цилиндрической ёмкости R: ");
            double m = Input("Введите объем жидкости M: ");
            double cube = a * a * a;
            double cylinder = 2 * Math.PI * Math.Pow(r, 2) * h;
            Console.WriteLine("\nОбъём куб-й ёмкости: {0}\nОбъём цилин-й ёмкости: {1}", cube, cylinder);
            if (m <= cube)
                Console.WriteLine("жидкость объёма M поместится в кубическую ёмкость");
            if (m <= cylinder)
                Console.WriteLine("жидкость объёма M поместится в цилиндрическую ёмкость");
            if (m <= cube + cylinder)
                Console.WriteLine("Жидкость объёма M поместится в обе ёмкости");
        }

        static double Input(string message)
        {
            Console.Write(message);
            double num = 0.0;
            try
            {
                num = Convert.ToDouble(Console.ReadLine());
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
