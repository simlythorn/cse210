using System;

public class Entry
{
    //public DateTime _date;
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _entryLocation;
    public string _entryWeather;
    public Entry(string dateText, string promptText, string entryText, string entryLocation, string entryWeather)
    {
        _date = dateText;
        _promptText = promptText;
        _entryText = entryText;
        _entryLocation = entryLocation;
        _entryWeather = entryWeather;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Location: {_entryLocation}");
        Console.WriteLine($"Weather: {_entryWeather}");
        Console.WriteLine($"Text: {_entryText}");
    }
}

