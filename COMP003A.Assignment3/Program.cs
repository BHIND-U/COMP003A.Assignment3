/* Author: Joshua Isidro
 * Course: COMP003A-L01
 * Purpose: Code for Assignment 3
 */

namespace COMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeric to letter grade using an if-else statement");
            Console.WriteLine("Enter a numeric grade from (0-100):");
            double numericGrade =Convert.ToDouble(Console.ReadLine());

            Convert.ToDouble(numericGrade);
            if (numericGrade >= 0)
            {
                if (numericGrade <= 100)
                {
                    if (numericGrade >= 90) { Console.Write("A"); }
                    else if (numericGrade >= 80) { Console.WriteLine("B"); }
                    else if (numericGrade >= 70) { Console.WriteLine("C"); }
                    else if (numericGrade >= 60) { Console.WriteLine("D"); }
                    else { Console.WriteLine("F"); }
                }
            }
            else { Console.WriteLine("Invalid input!"); }

            Console.WriteLine("******************************************************");
            Console.WriteLine("Integer to string day using a switch statement");
            Console.WriteLine("Enter an integer day of the week (1-7):");
            int numericDay = Convert.ToInt32(Console.ReadLine());

            switch (numericDay)
            {
                case 1:
                    Console.WriteLine("String Day: Monday");
                    break;
                case 2:
                    Console.WriteLine("String Day: Tuesday");
                    break;
                case 3:
                    Console.WriteLine("String Day: Wednesday");
                    break;
                case 4:
                    Console.WriteLine("String Day: Thursday");
                    break; 
                case 5:
                    Console.WriteLine("String Day: Friday");
                    break;
                case 6:
                    Console.WriteLine("String Day: Saturday");
                    break;
                case 7:
                    Console.WriteLine("String Day: Sunday");
                    break;
                default: Console.WriteLine("Invalid Day!");
                    break;

            }
            


            

        }
    }
}
