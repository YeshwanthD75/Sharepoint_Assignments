using System;

namespace classassignments
{
    class MainClass
    {
        static void Main(string[] args)
        {
            // To run Calculator, uncomment the line below:
            //RunCalculator();

            // To run Report Card Generator, uncomment the line below:
            RunReportCard();
        }

        // ================= Calculator Program =================
        static void RunCalculator()
        {
            while (true)
            {
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nSelect Operation:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.Write("Enter your choice (1-4): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                double result = 0;
                bool valid = true;

                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        break;
                    case 2:
                        result = num1 - num2;
                        break;
                    case 3:
                        result = num1 * num2;
                        break;
                    case 4:
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                        {
                            Console.WriteLine("Error: Division by zero!");
                            valid = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        valid = false;
                        break;
                }

                if (valid)
                    Console.WriteLine("Result: " + result);

                Console.Write("\nDo you want to perform another operation? (y/n): ");
                string cont = Console.ReadLine().ToLower();
                if (cont != "y") break;
            }
        }

        // ================= Report Card Program =================
        static void RunReportCard()
        {
            Console.Write("Enter Name of the candidate: ");
            string name = Console.ReadLine();

            Console.Write("Enter STD: ");
            string std = Console.ReadLine();

            Console.Write("Enter Division: ");
            string div = Console.ReadLine();

            Console.Write("Enter number of subjects: ");
            int subjectCount = Convert.ToInt32(Console.ReadLine());

            double total = 0;

            for (int i = 1; i <= subjectCount; i++)
            {
                Console.Write($"Enter marks for Subject {i}: ");
                double marks = Convert.ToDouble(Console.ReadLine());
                total += marks;
            }

            double average = total / subjectCount;

            Console.WriteLine("\n********************Report Card*************************");
            Console.WriteLine($"* Name of the candidate :- {name,-36}*");
            Console.WriteLine($"* STD:- {std,-47}*");
            Console.WriteLine($"* Div:- {div,-47}*");
            Console.WriteLine($"* Average Score :- {average,-36}*");
            Console.WriteLine("********************************************************");
        }
    }
}
