public class Gathering : Event
{
    private string _weather;

    public Gathering(string weather, string title, string description, string date, string time, Address address) : base(title, description, date, time, address, "Gathering")
    {
        _weather = weather;
    }

    public void DisplayFullDetails()
    {
        base.FullDetails();
        Console.WriteLine($"This even is outdoors, and the current projected forcast is:\n{_weather}");
    }
}