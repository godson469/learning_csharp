using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {   //Variables to store input & output data
            string firstNumber;
            string secondNumber;
            string thirdNumber;
            int result;

            //Collecting Numbers
            Console.Write("Input the first number: ");
            firstNumber = Console.ReadLine();

            Console.Write("Input the second number: ");
            secondNumber = Console.ReadLine();

            Console.Write("Input a third number: ");
            thirdNumber = Console.ReadLine();

            //Performing arithmetics & Displaying output
            result = (int.Parse(firstNumber) * int.Parse(secondNumber) * int.Parse(thirdNumber));
            Console.WriteLine("The answer is "+result);
        }
    }
}
