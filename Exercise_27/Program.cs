using System;
using System.IO;
//27. Имеется список учеников и результаты трёх тестов(баллы от 0 до 100). 
//Определить средний балл каждого ученика по трём тестам, вывести список учеников по убыванию среднего балла.

namespace Exercise_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = GetStudents("List.txt");
            if (students != null)
            {
                //for (int i = 0; i < students.Length; i++)
                //{       
                //    Console.WriteLine(students[i].Name);
                //    Console.WriteLine("Средний балл: {0:F2}\n", students[i].GetAverageResult());
                //}
                SortStudents(students);
                Console.WriteLine("Список учеников\n");
                for (int i = 0; i < students.Length; i++)
                {
                    Console.WriteLine(students[i].Name);
                    Console.WriteLine("Средний балл: {0:F2}\n", students[i].GetAverageResult());
                }
            }
        }

        static void SortStudents(Student[] students)
        {
            
            for (int i = 0; i < students.Length; i++)
            {
                double max = students[i].GetAverageResult();
                int maxInd = i;
                for (int j = i; j < students.Length; j++)
                {
                    if (students[j].GetAverageResult() > max)
                    {
                        max = students[j].GetAverageResult();
                        maxInd = j;
                    }
                }

                for (int j = maxInd; j > 0; j--)
                {
                    Student temp = students[j];
                    students[j] = students[j - 1];
                    students[j - 1] = temp;
                }

            }
        }
        static Student[] GetStudents(string fileName)
        {
            StreamReader fs = null;
            Student[] students = null;
            try
            {
                fs = new StreamReader("List.txt", System.Text.Encoding.Default);
                int count = Convert.ToInt32(fs.ReadLine());
                students = new Student[count];
                for (int i = 0; i < count; i++)
                {
                    string name = fs.ReadLine();
                    int res1 = Convert.ToInt32(fs.ReadLine());
                    int res2 = Convert.ToInt32(fs.ReadLine());
                    int res3 = Convert.ToInt32(fs.ReadLine());
                    students[i] = new Student(name, res1, res2, res3);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
            return students;
        }
    }

    class Student
    {
        public string Name { get; set; }
        private int[] results = new int[3];
        public Student(string name, int result1, int result2, int result3)
        {
            Name = name;
            results[0] = result1;
            results[1] = result2;
            results[2] = result3;
        }

        public double GetAverageResult()
        {
            return (results[0] + results[1] + results[2]) / 3.0;
        }
    }
}
