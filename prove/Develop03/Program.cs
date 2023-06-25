using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create four Reference objects
        Reference theReference1 = new Reference("Proverbs", 3, 5, 6);
        Reference theReference2 = new Reference("John", 3, 16);
        Reference theReference3 = new Reference("Philippians", 4, 13);
        Reference theReference4 = new Reference("Jeremiah", 29, 11);

        // Create four Scripture objects
        Scripture theScripture1 = new Scripture(theReference1, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        Scripture theScripture2 = new Scripture(theReference2, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Scripture theScripture3 = new Scripture(theReference3, "I can do all things through Christ which strengtheneth me.");
        Scripture theScripture4 = new Scripture(theReference4, "For I know the thoughts that I think toward you, saith the Lord, thoughts of peace, and not of evil, to give you an expected end.");

        // Add the Scripture objects to a list
        List<Scripture> scriptures = new List<Scripture> { theScripture1, theScripture2, theScripture3, theScripture4 };

        // Generate a random index
        Random random = new Random();
        int index = random.Next(scriptures.Count);

        // Select a random Scripture object
        Scripture randomScripture = scriptures[index];

        // Display the selected Scripture
        Console.WriteLine(randomScripture.Reference.GetDisplayText());
        Console.WriteLine(randomScripture.GetDisplayText());

        // Prompt the user to press enter or type quit
        Console.Write("\nPress 'enter' to hide a word\nType 'quit' to exit\nType 'save' to save\nType 'load' to load from file: ");
        string input = Console.ReadLine();

        // Continue prompting the user until they type quit or all words are hidden
        while (input != "quit" && !randomScripture.IsCompletelyHidden())
        {
            // Hide a random word
            randomScripture.HideRandomWord(2);

            // Clear the console and display the scripture again
            Console.Clear();
            Console.WriteLine(randomScripture.Reference.GetDisplayText());
            Console.WriteLine(randomScripture.GetDisplayText());


            // Prompt the user again
            Console.Write("\nPress 'enter' to hide a word\nType 'quit' to exit\nType 'save' to save\nType 'load' to load from file: ");
            input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }
            else if (input == "save")
            {
                Console.Write("Enter file name to save: ");
                string saveFile = Console.ReadLine();
                randomScripture.SaveFile(saveFile);
            }
            else if (input == "load")
            {
                Console.Write("Enter file name to load from: ");
                string loadFile = Console.ReadLine();
                randomScripture.LoadFile(loadFile);
            }
        }
    }
}