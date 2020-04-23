using System;

namespace Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables to store input & output data
            string firstNumber;
            string secondNumber;
            int result;

            //Collecting Numbers
            Console.Write("Input the first number: ");
            firstNumber = Console.ReadLine();

            Console.Write("Input the second number: ");
            secondNumber = Console.ReadLine();

            //Performing arithmetics & Displaying output
            result = (int.Parse(firstNumber) - int.Parse(secondNumber));
            Console.WriteLine("The answer is "+result);
        }
    }
}
