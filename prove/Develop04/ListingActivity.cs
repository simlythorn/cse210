using System;
using System.Collections.Generic;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity(string name, string description, int duration, int count, List<string> prompts) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;

    }
    public void Run()
    {
        DisplayStartingMessage(_name, _description, _duration);
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine("---"+GetRandomPrompt()+"---");
        Console.Write("You may begin in: ");
        for (int i = 3; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("");
        List<string> items = GetListFromUser();

        ShowProgressBar(2);
        DisplayEndingMessage(_name, _description, _duration);
        Console.Clear();

    }
    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }
    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        
        for (int i = 0; i < 3; i++)
        {
            Console.Write(">> ");
            string input = Console.ReadLine();
        }
        return items;
    }
    
}