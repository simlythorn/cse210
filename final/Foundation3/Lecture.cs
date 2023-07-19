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

    public override string GetFullDetails()
    {
        return $"Title: {_eventTitle}\nDescription: {_description}\nDate and Time: {_date} at {_time}\nLocation: {_address._street}, {_address._city}, {_address._zipcode}\nSpeaker: {_speaker}\nCapacity: {_capacity}";

    }

    public override string GetShortDescription()
    {
        return $"Lecture: {_eventTitle} on {_date}";
    }
}