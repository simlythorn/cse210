using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome To My Journal!");
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string entryText = Console.ReadLine();
                Console.Write("Enter your location: ");
                string entryLocation = Console.ReadLine();
                Console.Write("Enter the weather: ");
                string entryWeather = Console.ReadLine();
                Entry newEntry = new Entry(DateTime.Now, prompt, entryText, entryLocation, entryWeather);
                theJournal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                Console.WriteLine("\n");
                theJournal.DisplayAll();
                Console.WriteLine("\n");
            }
            else if (choice == "3")
            {
                Console.WriteLine("\n");
                Console.Write("Enter file name to load from:");
                string loadFile = Console.ReadLine();
                theJournal.LoadFromFile(loadFile);
                Console.WriteLine("\n");
            }
            else if (choice == "4")
            {
                Console.Write("Enter file name to save to:");
                string saveFile = Console.ReadLine();
                theJournal.SaveToFile(saveFile);
            }
            else if (choice == "5")
            {
                // Do nothing, the loop will exit
            }
            else
            {
                Console.WriteLine("Invalid choice, try again.");
            }
        }
    }
}