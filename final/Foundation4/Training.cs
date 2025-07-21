using System.Dynamic;

public abstract class Training
{
    private DateTime _date;
    private float _length;

    public Training(float minutes)
    {
        _date = DateTime.Now;
        _length = minutes;
    }
    public DateTime GetDate()
    {
        return _date;
    }
    public float GetLength()
    {
        return _length;
    }
    public abstract string GetDistSpeedPace();
    public void GetSummary()
    {
        Console.WriteLine($"{GetDate()} ({GetLength()} min): {GetDistSpeedPace()}");
    }
}