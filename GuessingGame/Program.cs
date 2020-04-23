using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game Starts
            Console.WriteLine("Welcome to the Guessing Game");
            Console.WriteLine("Please choose a difficulty level by inputing 1, 2 or 3");
            Console.WriteLine("\t1. Easy\t2. Medium\t3. Hard");
            //Choosing a game difficulty
            int level = int.Parse(Console.ReadLine());
            if (level == 1) {
                //easy mode
                int guesses = 6;
                Random rmd = new Random();
                int num = rmd.Next(1, 10);
                int guess = 0;
                do {
                    guess = int.Parse(Console.ReadLine());
                    guesses --;
                    Console.WriteLine("That was wrong");
                    Console.WriteLine("You have "+guesses+" guesses left");
                } while (guesses > 0 & guess != num);
                if (guesses == num) {
                    Console.WriteLine("You got it right!");
                } else {
                    Console.WriteLine("Game over");
                }
            } else if (level == 2) {
                //medium mode
                int guesses = 4;
                Random rmd = new Random();
                int num = rmd.Next(1, 20);
                int guess = 0;
                do {
                    guess = int.Parse(Console.ReadLine());
                    guesses --;
                    Console.WriteLine("That was wrong");
                    Console.WriteLine("You have "+guesses+" guesses left");
                } while (guesses > 0 & guess != num);
                if (guesses == num) {
                    Console.WriteLine("You got it right!");
                } else {
                    Console.WriteLine("Game over");
                }
            } else if (level == 3) {
                //hard mode
                int guesses = 3;
                Random rmd = new Random();
                int num = rmd.Next(1, 50);
                int guess = 0;
                do {
                    guess = int.Parse(Console.ReadLine());
                    guesses --;
                    Console.WriteLine("That was wrong");
                    Console.WriteLine("You have "+guesses+" guesses left");
                } while (guesses > 0 & guess != num);
                if (guesses == num) {
                    Console.WriteLine("You got it right!");
                } else {
                    Console.WriteLine("Game over");
                }
            } else {
                //no level selected
                Console.WriteLine("Wrong Input");
            }
        }
    }
}
