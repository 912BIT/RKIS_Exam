using System;

//24. Известны данные о количестве мальчиков и девочек в нескольких классах.
//    Отсортировать названия классов по возрастанию процента мальчиков, 
//    определить количество классов, в которых мальчиков больше, чем девочек и вывести названия этих классов отдельно.

namespace Exercise_24
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolClass[] classes = new SchoolClass[3];
            classes[0] = new SchoolClass("1А", 7, 10);
            classes[1] = new SchoolClass("2Б", 15, 12);
            classes[2] = new SchoolClass("5В", 10, 10);
            Sort(classes);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(classes[i].BoysPercent());
                Console.WriteLine("Названия класса: " + classes[i].Name);
            }
        }

        static void Sort(SchoolClass[] clas)
        {
            int[] percents = new int[clas.Length];
            for (int j = 0; j < clas.Length; j++)
            {
                SchoolClass min = clas[j];
                double min_percent = min.BoysPercent();
                int min_ind = j;
                //поиск элемента с минимальным процентом
                for (int i = j; i < clas.Length; i++)
                {
                    double percent = clas[i].BoysPercent();
                    if (percent < min_percent)
                    {
                        min_percent = percent;
                        min = clas[i];
                        min_ind = i;
                    }
                }

                SchoolClass temp = min;
                Console.WriteLine("temp = " + temp.Name);
                clas[min_ind] = clas[j];
                Console.WriteLine("clas[min_ind] = " + clas[min_ind].Name);
                clas[j] = temp;
                Console.WriteLine("clas[j] = " + clas[j].Name);
            }

        }
        static int Input(string message)
        {
            Console.Write(message);
            int num = 0;
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

    class SchoolClass
    {
        public int Girls { get; set; }
        public int Boys { get; set; }
        public string Name { get; set; }
        public SchoolClass(string name, int boys, int girls)
        {
            Name = name;
            Boys = boys;
            Girls = girls;
        }

        public double BoysPercent()
        {
            if (Boys + Girls != 0)
                return (Boys * 100.0) / (Boys + Girls);
            return -1;
        }
    }
}
