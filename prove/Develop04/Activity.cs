using System;
using System.Collections.Generic;
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity (string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage(string name, string description, int duration)
    {
        Console.WriteLine(" ");
        Console.WriteLine("Welcome to the " + name + " Activity.");
        Console.WriteLine("");
        Console.WriteLine(description);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }
    public void DisplayEndingMessage(string name, string description, int duration)
    {
        Console.WriteLine("Good Job!");
        ShowSpinner(2);
        //Console.WriteLine("You have completed the " + name + " activity for " + duration + " seconds.");
        List<string> AnimationTexts = new List<string>();
          AnimationTexts.Add("You ");
          AnimationTexts.Add("have ");
          AnimationTexts.Add("completed ");
          AnimationTexts.Add("the ");
          AnimationTexts.Add(name + " ");
          AnimationTexts.Add("activity ");
          AnimationTexts.Add("for ");
          AnimationTexts.Add(duration + " ");
          AnimationTexts.Add("seconds.");
          foreach (string text in AnimationTexts)
            {
                Console.Write(text);
                Console.Write(" ");
                Thread.Sleep(300);
                Console.Write("\b \b");
            }
        Console.WriteLine(" ");
        ShowSpinner(2);
        Console.Clear();
    }
    public void ShowSpinner(int seconds)
    {
        
        List<string> AnimationStrings = new List<string>();
            AnimationStrings.Add("|");
            AnimationStrings.Add("/");
            AnimationStrings.Add("-");
            AnimationStrings.Add("\\");
            AnimationStrings.Add("|");
            AnimationStrings.Add("/");
            AnimationStrings.Add("-");
            AnimationStrings.Add("\\");
            AnimationStrings.Add("|");
            foreach(string s in AnimationStrings)
            {
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
            Console.WriteLine(" ");
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(500);
            
        }
    }

    public void ShowProgressBar(int seconds)
    {
    int width = Console.WindowWidth - 2;
    
    // Clear console
    Console.Clear();
    
    for (int i = 0; i < width; i++)
    {
        double progress = (double)i / width;
        int barLength = (int)(progress * width);
        
        Console.Write("\r[");
        Console.Write(new string('o', barLength));
        Console.Write("]");
        
        Thread.Sleep(seconds * 1000 / width);
    }
    
    Console.WriteLine();
    }
    
}