using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> COURSES = new Dictionary<string, string>();
            Console.WriteLine("Enter three courses would you like to add seperated  by a comma");
            string course = Console.ReadLine();
           
            Console.WriteLine("Enter the grades of the three course grades you entered earlier seperated by a comma");
            string grades = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                COURSES.Add(course.Split(",")[i], grades.Split(',')[i]);
            }
            COURSES.Select(i => $"{i.Key}: {i.Value}").ToList().ForEach(Console.WriteLine);





        }
    }
}
