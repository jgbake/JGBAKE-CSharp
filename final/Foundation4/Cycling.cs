public class Cycling : Activity
{
    private float _speed;
    public Cycling(float speed, DateOnly theDate, float activityLength) : base(theDate, "Cycling", activityLength)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        return _speed / 60 * base.GetActivityLength();
    }
    public override float GetSpeed()
    {
        return _speed;
    }
    public override float GetPace()
    {
        return 60 / _speed;
    }
}