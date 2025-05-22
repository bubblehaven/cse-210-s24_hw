using System.Diagnostics.Contracts;
using System.Dynamic;

public class Fraction
{
    public int _top;
    public int _bottom;

    public Fraction()//because the default fraction is 1/5
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

    public int GetBottom()
    {
        return _bottom;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetFractionDec()
    {
        return (double) _top / _bottom;
    }
}