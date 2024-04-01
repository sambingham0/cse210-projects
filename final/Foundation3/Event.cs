public class Event
{
    protected string _title;
    private string _description;
    protected DateTime _dateTime;
    private Address _address;

    public Event(string title, string description, DateTime dateTime, Address address)
    {
        _title = title;
        _description = description;
        _dateTime = dateTime;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate & Time: {_dateTime}\nAddress: {_address.GetAddressString()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Event Type: Generic\nTitle: {_title}\nDate: {_dateTime.ToShortDateString()}";
    }
}