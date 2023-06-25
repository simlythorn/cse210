using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts;
    
    public string GetRandomPrompt()
    {
        List<string> _prompts = new List<string> { "What are you grateful for today?", "What did you learn today?", "What made you happy today?",
        "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", 
        "If I had one thing I could do over today, what would it be?", "Who was the most interesting person I interacted with today?" };
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }  
}
