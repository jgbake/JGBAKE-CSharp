using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int newTop)
    {
        _top = newTop;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int NewBottom)
    {
        _bottom = NewBottom;
    }

    public string GetFractionString()
    {
        return ($"{_top}/{_bottom}");
    }
    public double GetDecimalValue()
    {
        return (Convert.ToDouble(_top))/(Convert.ToDouble(_bottom));
    }

}