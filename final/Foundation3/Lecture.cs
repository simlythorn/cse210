using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string eventTitle, string description, string date, string time, Address address, string speaker, int capacity)
        : base(eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public  string GetFullDetails()
    {
        return $"{_eventTitle}\n{_description}\n{_date} at {_time}\n{_address._street}, {_address._city}, {_address._zipcode}\nSpeaker: {_speaker}\nCapacity: {_capacity}";

    }

    public string GetShortDescription()
    {
        return $"Lecture: {_eventTitle} on {_date}";
    }

    


}