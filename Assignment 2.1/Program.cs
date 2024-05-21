using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Assignment 2.1");
            Console.WriteLine("Name: Isaac Jang\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------PART 1---------------\n");
            Console.ForegroundColor = ConsoleColor.White;

            //create new object called stud1
            Student stud1 = new Student();

            Console.Write("Enter student id: ");
            stud1.StudentId = int.Parse(Console.ReadLine());

            Console.Write("Eunter student first name: ");
            stud1.StudentFName = Console.ReadLine();

            Console.Write("Enter student last name: ");
            stud1.StudentLName = Console.ReadLine();

            Console.Write("Enter student's Grade: ");
            stud1.StudentGrade = char.Parse(Console.ReadLine().ToUpper());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n{stud1.StudentFName} {stud1.StudentLName} with StudentId:{stud1.StudentId} has a(n) {stud1.StudentGrade}!");
            Console.ForegroundColor = ConsoleColor.White;



            // TRANSITION
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPress any key to continue!\n");
            Console.ReadKey();


            // PART 3
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------PART 3---------------\n");
            Console.ForegroundColor = ConsoleColor.White;

            StartPointPt3:

            Console.WriteLine("\nI can calculate the following:");
            Console.WriteLine("Type the letter next to the shape that you want: \n\n" +
                "   A: Add 2 Numbers\n" +
                "   B: Add 3 Numbers\n" +
                "   C: Multiple 2 Numbers\n" + 
                "   D: Multiple 3 Numbers\n");
            Console.Write("Your Choice: ");
            string choice = Console.ReadLine().ToUpper();

            int num1, num2, num3 = 0;

            switch (choice)
            {
                case "A":
                    Console.Write("\nEnter first number: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    num2 = int.Parse(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nThe sum is: {OverloadMath.Add(num1, num2)}");
                    Console.ForegroundColor = ConsoleColor.White;

                    break;

                case "B":
                    Console.Write("\nEnter first number: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    num2 = int.Parse(Console.ReadLine());

                    Console.Write("Enter third number: ");
                    num3 = int.Parse(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nThe sum is: {OverloadMath.Add(num1, num2,num3)}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case "C":
                    Console.Write("\nEnter first number: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    num2 = int.Parse(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nThe product is: {OverloadMath.Multiply(num1, num2)}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case "D":
                    Console.Write("\nEnter first number: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    num2 = int.Parse(Console.ReadLine());

                    Console.Write("Enter third number: ");
                    num3 = int.Parse(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nThe product is: {OverloadMath.Multiply(num1, num2, num3)}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;


                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You didn't enter one of the options. Please try again.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;


            }

            while (true)
            {
                // ask user if they want to try again
                Console.WriteLine("\nWant to try again? (Y / N)");
                char answer = char.Parse(Console.ReadLine().ToUpper());

                // wants to continue
                if (answer == 'Y')
                {
                    goto StartPointPt3;
                }

                // does not want to continue
                else if (answer == 'N')
                {
                    break;
                }

                // invaid entry
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEnter valid character");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
            }


            // CLOSING MESSAGE
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nHave a great day!");

            Console.ReadKey();
        }


    }
}
