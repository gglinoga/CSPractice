using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Greg's Grade Book");

            while(true)
            {
                Console.WriteLine("Enter grades.  Enter q to exit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }

                try
                {
                var grade = double.Parse(input);
                book.AddGrade(grade);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }

            var stats = book.GetStatistics();

            Console.WriteLine($"The average grade is {stats.Average:N2}");
            Console.WriteLine($"The high grade is {stats.High}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The Letter grade is {stats.Letter}");


        }
    }
}

