using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> GRADES = new List<int>();
            Console.WriteLine("Would you like to input a grade?");
            string input = Console.ReadLine();
            if (input == "yes")
            {
                do
                {
                    Console.WriteLine("Input your grade.");
                    input = Console.ReadLine();
                    GRADES.Add(Convert.ToInt32(input));
                    Console.WriteLine("Would you like to input another grade?");
                    input = Console.ReadLine();
                }
                while (input != "no");
            }
            Console.WriteLine("Your grade average is " + GRADES.Average());  
        }
    }
}
