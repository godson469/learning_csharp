using System;
using System.Collections.Generic;
using System.Linq;

namespace DayGrader
{
    class Program
    {
        static void Main(string[] args)
        {
            //An array holding days of the week
            List<string> days = new List<string>();
            days.Add("Sunday");
            days.Add("Monday");
            days.Add("Tuesday");
            days.Add("Wednesdia");
            days.Add("Thursday");
            days.Add("Friday");
            days.Add("Saturday");
            

            //A list to hold things I must attend to daily (mustDos)
            string[] mustDos = new string[5];
            //Adding to my daily mustDos
            mustDos[0] = "Hotelsng";
            mustDos[1] = "Startng";
            mustDos[2] = "UOPeople";
            mustDos[3] = "AISaturdays";
            mustDos[4] = "Rest";

            int[] grades = new int[5];


            
            Console.WriteLine("Today is "+days[0]);
            Console.WriteLine("On a scale of 1-10, how far did you get with fulfilling each task");

            Console.Write(mustDos[0]+" - ");
            grades[0] = int.Parse(Console.ReadLine());
            Console.Write(mustDos[1]+" - ");
            grades[1] = int.Parse(Console.ReadLine());
            Console.Write(mustDos[2]+" - ");
            grades[2] = int.Parse(Console.ReadLine());
            Console.Write(mustDos[3]+" - ");
            grades[3] = int.Parse(Console.ReadLine());
            Console.Write(mustDos[4]+" - ");
            grades[4] = int.Parse(Console.ReadLine());

            int perfect_score = grades.Length*10;

            //Task Grading
            int score = grades.Sum();
            Console.WriteLine(score);
            
            //Remarks
            if (score < perfect_score/2 & grades[4] >= 5) {
                Console.WriteLine("You didn't do well enough!");
                Console.WriteLine("You rested well enough tho!");
            } else if (score < perfect_score/2 & grades[4] < 5) {
                Console.WriteLine("You didn't do well enough!");
                Console.WriteLine("You should get some rest too!");
            } else if (score >= perfect_score/2 & grades[4] >= 5) {
                Console.WriteLine("You worked hard today!");
                Console.WriteLine("You rested well enough too!");
            } else {
                Console.WriteLine("You worked hard today!");
                Console.WriteLine("You should get some rest tho!");
            }
        }
    }
}
