using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Priya's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(78.9);
            book.AddGrade(67.8);
            book.AddGrade(9.8);
            book.AddGrade(4.8);
            var stats = book.GetStatistics();
            
            Console.WriteLine($"The average grade is {stats.Average:N4}");
            Console.WriteLine($"The highest grade is {stats.High:N4}");
            Console.WriteLine($"The lowest grade is {stats.Low:N4}");

            // Creation of Array: double[] numbers = new double[] { 12.7, 13.6, 14.8, 7.5 };
            // var numbers = new[] {12.7, 13.6, 14.8, 7.5};
            
            // The creation of List using explicit typing
            // List<double> grades = new List<double>(); 
            // List  creation using implicit typing
            // var grades = new List<double>() {12.7, 13.6, 14.8, 7.5};
        }
    }
}