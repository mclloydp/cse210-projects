using System;

class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, Address address, string rsvpEmail)
        : base(title, description, date, address)
    {
        this._rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Reception\nRSVP Email: {_rsvpEmail}";
    }
}
