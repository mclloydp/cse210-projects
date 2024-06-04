using System;

abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private Address _address;

    public Event(string title, string description, DateTime date, Address address)
    {
        this._title = title;
        this._description = description;
        this._date = date;
        this._address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nAddress: {_address.GetFullAddress()}";
    }

    public abstract string GetFullDetails();

    public string GetShortDescription()
    {
        return $"Type: {this.GetType().Name}\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}

