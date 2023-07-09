using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager(new List<Goal>(), 0);

        string choice = " ";
        while (choice != "6")
        {
            Console.WriteLine(" ");
            Console.WriteLine($"You have {goalManager.GetScore()} points.");
            Console.WriteLine(" ");
            Console.WriteLine("1. Create New Goals");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                goalManager.CreateGoal();
            }
            else if (choice == "2")
            {
                goalManager.ListGoalDetails();
            }
            else if (choice == "3")
            {
                Console.Write("Enter file name to save: ");
                string saveFile = Console.ReadLine();
                goalManager.SaveGoals(saveFile);
            }
            else if (choice == "4")
            {
                Console.Write("Enter file name to load: ");
                string LoadFile = Console.ReadLine();
                goalManager.LoadGoals(LoadFile);
                
            }
            else if (choice == "5")
            {
                goalManager.RecordEvent();
            }
            else if (choice == "6")
            {
                // Do nothing
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}