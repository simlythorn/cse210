using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public Journal()
    {
        _entries = new List<Entry>();
    }
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry anEntry in _entries)
        {
            anEntry.Display();
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry anEntry in _entries)
            {
                writer.WriteLine($"{anEntry._entryLocation} / {anEntry._entryWeather}");
                writer.WriteLine($"{anEntry._date}~~{anEntry._promptText}~~{anEntry._entryText}");
                
            }
        }
        Console.WriteLine("\n");
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            // Split the line into fields
            string[] fields = line.Split(',');
           
            // Check if the line has the expected number of fields
            if (fields.Length > 0)
            {
                Console.WriteLine($"{line}");
                continue;
            }
            
            //DateTime date = DateTime.Parse(fields[0]);
            string date = fields[0];
            string entryLocation = fields[1];
            string entryWeather = fields[2];
            string promptText = fields[3];
            string entryText = fields[4];
            

            // Create a new Entry object
            Entry newEntry = new Entry(date, promptText, entryText, entryLocation, entryWeather);
            _entries.Add(newEntry);
        }
    }
 

}

