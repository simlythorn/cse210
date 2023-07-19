using System;
public class Reception : Event
{
    private string _RsvpEmail;
    public Reception(string eventTitle, string description, string date, string time, Address address, string RsvpEmail) : base(eventTitle, description, date, time, address)
    {
        _RsvpEmail = RsvpEmail;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nRSVP to: {_RsvpEmail}";
    }

    public override string GetShortDescription()
    {
        return $"Reception: " + base.GetShortDescription();
    }

}

