using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
           string someName = "";
           Console.Write("Enter your name, please: ");
           someName = Console.ReadLine();

           Console.WriteLine("Hello " + someName +"!");
        }
    }
}
