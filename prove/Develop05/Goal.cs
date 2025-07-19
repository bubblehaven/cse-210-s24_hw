using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class Goal
{
    private string _name;
    private string _description;
    private int _pointGain;
    private bool _isComplete;
    public Goal(string name, string description, int pointGain)
    {
        _name = name;
        _description = description;
        _pointGain = pointGain;
        _isComplete = false;
    }
    public Goal(string name, string description, int pointGain,bool isComplete)
    {
        _name = name;
        _description = description;
        _pointGain = pointGain;
        _isComplete = isComplete;
    }
    public int GetPointGain()
    {
        return _pointGain;
    }
    public string GetDescription()
    {
        return _description;
    }

    public string GetName()
    {
        return _name;
    }
    public bool GetIsComplete()
    {
        return _isComplete;
    }
    public void SetComplete()
    {
        _isComplete = true;
    }
    public virtual string StoreGoal()
    {

        return $"g,{_name},{_description},{_pointGain},{_isComplete}";
    }
    public virtual void DisplayGoal()
    {
        if (_isComplete)
        {
            Console.WriteLine($"COMPLETED {_name}: {_description}\nType: One Time Completion\nXP gain: {_pointGain}");
        }
        else
        {
            Console.WriteLine($"{_name}: {_description}\nType: One Time Completion\nXP gain: {_pointGain}");

        }
    }


    public virtual void GoalComplete(ScoreTracker Tracker)
    {
        if (!_isComplete)
        {
            Console.WriteLine($"GOAL COMPLETED");
            Console.WriteLine($"{_name}: {_description}");
            Console.WriteLine($"Points gained: {_pointGain}");
            Tracker.AddPoints(_pointGain);
            _isComplete = true;
        }
        else
        {
            Console.WriteLine("Goal already completed");
        }
        Console.WriteLine("Press enter to continue");
        Console.Read();
    }
}