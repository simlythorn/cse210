using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        /*Console.Write("What is the magic number? ");
        string number = Console.ReadLine();
        int margicNumber = int.Parse(number);*/

        Random rnd = new Random();
        int margicNumber = rnd.Next(1,101);
        int guessTime = 0;
        while (margicNumber > 0)
        {
            guessTime++;
            Console.Write("What is your guess? ");
            string numberGuess = Console.ReadLine();
            int guess = int.Parse(numberGuess);
            if (guess < margicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > margicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You are right!, it took {guessTime} time to guess.");
                Console.Write("Do you want to continue? ");
                string response = Console.ReadLine();
                if (response.ToLower() == "yes")
                {
                    Main(args);     // I use Main(args) because I want the new random number and new guessTime
                                    /* If i don't use Main(args) I will but use break instead and remove else statement underneat, it will 
                    still the same Random number and keep continue count the old gessTime plus the new gessing time  */                  
                }
                else
                {
                    break;          
                }
            }
        }    
    }
}