public class Reception : Event
{
    private string _whereToRegister;

    public Reception(string whereToRegister, string title, string description, string date, string time, Address address) : base(title, description, date, time, address, "Reception")
    {
        _whereToRegister = whereToRegister;
    }

    public void DisplayFullDetails()
    {
        base.FullDetails();
        Console.WriteLine($"To RSVP, send a message to: {_whereToRegister}");
    }
}