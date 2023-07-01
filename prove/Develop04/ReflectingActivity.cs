using System;
using System.Collections.Generic;
public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
        _prompts = prompts;
        _questions = questions;

        // Set other values here that are unique to the Reflecting Activity
    }
    public void Run()
    {
        DisplayStartingMessage(_name, _description, _duration);
        Console.WriteLine("Consider the following prompts: \n");
        Console.WriteLine(" ");
        Console.WriteLine("---"+ GetRandomPrompt()+ "---");
        Console.WriteLine(" ");
        Console.WriteLine("When you have something in mind, press 'enter' to continue.");
        string output1 = Console.ReadLine();
        Console.WriteLine(" ");
        Console.WriteLine("Now ponder on each of the following question as they related to this experience.");
        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Clear();
        for (int i = 0; i < 3; i++)
        {
            Console.Write(">>"+ GetRandomQuestion());
            ShowProgressBar(2);
        }

        DisplayEndingMessage(_name, _description, _duration);
        Console.Clear();
    }
    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }
    public string GetRandomQuestion()
    {
        Random rnd = new Random();
        int index = rnd.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }
    public void DisplayQuestions()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(5);
        }
    }

    
}
    
