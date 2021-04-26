using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.AddGrade(89.1);

            var grades = new List<double>() { 82.1, 10.3, 91.2 };
            grades.Add(56.1);
            var result = 0.0;
            foreach (double grade in grades)
            {
                result += grade;
            }
            result /= grades.Count;

            Console.WriteLine($"The average grade is {result:N1}");

        }
    }
}
