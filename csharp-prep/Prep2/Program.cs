using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is the percentage of your grade? ");
        string percentage = Console.ReadLine();
        int number = int.Parse(percentage);
        string letter = " ";
        
        if (number >= 90 )
        {
            letter = "A";
        }
        else if (number < 90 && number >=80)
        {
            letter = "B";
           
        }
        else if (number < 80 && number >=70)
        {
            letter = "C";
            
        }
        else if (number < 70 && number >=60)
        {
            letter = "D";
            
        }
        else 
        {
            letter = "F";
        }

        int lastDigit = number % 10;
        string symbol = "";
        if (lastDigit >= 7 && letter != "A" && letter != "F")
        {
            symbol = "+"; 

        }
        else if (lastDigit < 3 && letter != "F")
        {
            symbol = "-";
        }
        else
        {
            
            symbol = "";
        }

        Console.WriteLine($"Your grade is {letter}{symbol}.");

        if (number > 70)
        {
            Console.WriteLine("Congratulation, you passed the class.");
        }
        else
        {
            Console.WriteLine("Sorry, you failed please try again.");
        }

    }
}