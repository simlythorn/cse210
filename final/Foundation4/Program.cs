using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Healty Sport Club!");
        Console.WriteLine(" ");
        List<Activity> activities = new List<Activity>();
        while(true)
        {
            Console.WriteLine("Please select activity you want to track");
            Console.WriteLine("1. Running Activity");
            Console.WriteLine("2. Cycling Activity");
            Console.WriteLine("3. Swimming Activity");
            Console.WriteLine("4.Exit");
            Console.Write("Select number of choice you want: ");
            string choice = Console.ReadLine();
            if(choice == "4")
            {
                break;
            }
            Console.Write("Enter the date (yyyy-mm-dd): ");
            string date = Console.ReadLine();
            Console.Write("Enter the length of the activity in minutes: ");
            int lengthInMins = int.Parse(Console.ReadLine());

            if (choice == "1")
            {
                Console.Write("Enter the runing distance in miles: ");
                double distance = double.Parse(Console.ReadLine());

                Runing runing = new Runing(date, lengthInMins, distance);
                activities.Add(runing);
            }
            else if (choice == "2")
            {
                Console.Write("Enter the cycling speed in mph: ");
                double speed = double.Parse(Console.ReadLine());

                Cycling cycling = new Cycling(date, lengthInMins, speed);
                activities.Add(cycling); 
            }
            else if (choice == "3")
            {
                Console.Write("Enter the number of swimming lap: ");
                int numLap = int.Parse(Console.ReadLine());

                Swimming swimming = new Swimming(date, lengthInMins, numLap);
                activities.Add(swimming);
            }
            else 
            {
               Console.WriteLine("Invalid choice. Please try again."); 
            }

            Console.WriteLine(" ");
            foreach(Activity a in activities)
            {
                Console.WriteLine(a.GetSummary());
            }
            Console.WriteLine(" ");

        }
    }
}

