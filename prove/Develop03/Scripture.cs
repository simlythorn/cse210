using System;
using System.Collections.Generic;
using System.IO;


public class Scripture 
{
    private  Reference _reference;
    private List<Word> _words;
    public Reference Reference
    {
        get 
        { 
            return _reference;
        }
    }
    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = new List<Word>();              // Creating a new instance of the List<Word> class and assigning to the _words 
        string[] words = text.Split(' ');       //Split the text by spaces and create a word object for each word
        foreach (string word in words)
        {
            _words.Add(new Word(word));        // create a new Word object _words.Add(word); // add it to the list
        }
    }

    public void HideRandomWord(int numberToHide)
    {
        Random random = new Random();
        int count = 0; // initialize the counter
        while (count < numberToHide) // check the condition
        {
            int index = random.Next(_words.Count); // generate a random index
            _words[index].Hide(); // hide the word at that index
            count++; // increment the counter
        }
    }
    public string GetDisplayText()
    {
       string displayText = "";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";  // add a space character (" ") after each word because I want to separate the words in the display text
        }
        return displayText;
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    public void SaveFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine($"{_reference.GetDisplayText()}");

            foreach (Word word in _words)
            {
                writer.WriteLine(word.GetDisplayText());
            }
        }
    }
    public void LoadFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        if (lines.Length > 0)
        {
            // Parse the first line to extract the book, chapter, and verse(s) information
            string[] referenceParts = lines[0].Split(' ');
            string book = referenceParts[0];
            int chapter = int.Parse(referenceParts[1].Split(':')[0]);
            string[] verses = referenceParts[1].Split(':')[1].Split('-');
            int startVerse = int.Parse(verses[0]);
            int endVerse = verses.Length > 1 ? int.Parse(verses[1]) : startVerse;

            // Create a new Reference object
            _reference = new Reference(book, chapter, startVerse, endVerse);

            _words = new List<Word>();
            for (int i = 1; i < lines.Length; i++)
            {
                _words.Add(new Word(lines[i]));
            }
        }
    
    }
}






























































































































