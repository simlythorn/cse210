using System;

public class Entry
{
    public DateTime _date;
    public string _promptText;
    public string _entryText;
    public string _entryLocation;
    public string _entryWeather;
    public Entry(DateTime dateText, string promptText, string entryText, string entryLocation, string entryWeather)
    {
        _date = dateText;
        _promptText = promptText;
        _entryText = entryText;
        _entryLocation = entryLocation;
        _entryWeather = entryWeather;
    }
    public void Display()
    {
        Console.WriteLine($"{_date} - {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine(_entryLocation);
        Console.WriteLine(_entryWeather);
    }
}

