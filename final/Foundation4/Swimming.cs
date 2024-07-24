public class Swimming : Activity
{
    private int _laps;
    public Swimming(int laps, DateOnly theDate, float activityLength) : base(theDate, "Swimming", activityLength)
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        return _laps * (float)0.0310686;
    }
    public override float GetSpeed()
    {
        return GetDistance() / base.GetActivityLength() * 60;
    }
    public override float GetPace()
    {
        return 60 / GetSpeed();
    }
}