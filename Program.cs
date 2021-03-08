using System;
using System.Threading;

namespace Calculator
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello, welcome to Ashley's calculator.");
            Thread.Sleep(1000);
            
            Console.WriteLine("This calculator can be used for basic arithmetic.");
            Thread.Sleep(1000);

            //Ask user to enter values
            double firstNumber;
            Console.WriteLine("Please enter the first number: ");
            while (!Double.TryParse(Console.ReadLine(), out firstNumber))
                Console.WriteLine("Invalid input! Try again.");

            double secondNumber;
            Console.WriteLine("Please enter the second number: ");
            while (!Double.TryParse(Console.ReadLine(), out secondNumber))
                Console.WriteLine("Invalid input! Try again.");

            //Ask user to choose operation
            Console.WriteLine("Please enter an operation from the list: x, -, *, / ");
            //Switch statement for math operations
            switch (Console.ReadLine())
            {
                case "+":
                    double aresult = firstNumber + secondNumber;
                    Console.WriteLine($"Result: {aresult}");
                    break;
                case "-":
                    double sresult = firstNumber - secondNumber;
                    Console.WriteLine($"Result: {sresult}");
                    break;
                case "*":
                    double mresult = firstNumber * secondNumber;
                    Console.WriteLine($"Result: {mresult}");
                    break;
                case "/":
                    double dresult = firstNumber / secondNumber;
                    if (secondNumber != 0)
                        Console.WriteLine($"Result: {dresult}");
                    else
                        Console.WriteLine("Invalid divisor.");
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}