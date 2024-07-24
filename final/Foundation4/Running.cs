public class Running : Activity
{
    private float _distance;
    public Running(float distance, DateOnly theDate, float activityLength) : base(theDate, "Running", activityLength)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }
    public override float GetSpeed()
    {
        return _distance / base.GetActivityLength() * 60;
    }
    public override float GetPace()
    {
        return base.GetActivityLength() / _distance;
    }
}