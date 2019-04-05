using System;

namespace Treehouse.FitnessFrog
{
    class Program
    {
        static void Main()
        {
            int runningTotal = 0;
            //Prompt the user for minutes exercised
            Console.Write("Enter how many minutes you exercised: ");
            string entry = Console.ReadLine();
            int minutes = int.Parse(entry);
            runningTotal = runningTotal + minutes;
            //Add minutes exercised to total


            //Display total minutes exercised to the screen
            Console.WriteLine("You've exercised " + runningTotal + " minutes.");
            //Repeat until the user quits
        }
    }
}