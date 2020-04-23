using System;

namespace Variables2
{
    class Program
    {
        static void Main(string[] args)
        {   // Variables to hold our inputs
            int firstNumber;
            int secondNumber;
            int result;
            // Collecting the first number
            Console.Write("Please enter the first number: ");
            firstNumber = int.Parse(Console.ReadLine());
            // Collecting the second number
            Console.Write("Please enter the second number: ");
            secondNumber = int.Parse(Console.ReadLine());
            // Summing the numbers and displaying the result in a string
            result = firstNumber + secondNumber;
            Console.WriteLine("The answer is "+result);
        }
    }
}
