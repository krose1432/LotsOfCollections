using System;

namespace Parallel_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] COURSE_SUBJECT = new string[3];
            string[] COURSE_NUMBER = new string[3];

            Console.WriteLine("Input 3 course names seperated by a comma");
            string input = Console.ReadLine().ToUpper();
            COURSE_SUBJECT = input.Split(',');
            for (int i = 0; i < COURSE_SUBJECT.Length; i++)
            {
                COURSE_SUBJECT[i] = COURSE_SUBJECT[i].Trim();
            }
                       
            Console.WriteLine("Input the 3 course numbers correlating to the Course Subject.");
            input = Console.ReadLine().ToUpper();
            COURSE_NUMBER = input.Split(',');
            for (int i = 0; i < COURSE_NUMBER.Length; i++)
            {
                COURSE_NUMBER[i] = COURSE_NUMBER[i].Trim();
            }
         
            string[] dates = { "first", "second", "third" };
            for (int i = 0; i < COURSE_NUMBER.Length; i++)
            {
                Console.WriteLine("The "  + dates[i] + " course you entered is " + COURSE_SUBJECT[i] + COURSE_NUMBER[i]);
            }
            
        }
    }
}
