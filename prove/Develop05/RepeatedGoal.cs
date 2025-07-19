using System.Numerics;

public class RepeatedGoal : Goal
{
    private int _totalCompletions;
    private int _currentCompletions;
    private int _totalCompletionPoints;

    public RepeatedGoal(string name, string description, int pointGain, int totalCompletions, int totalCompletionPoints) : base(name, description, pointGain)
    {
        _totalCompletions = totalCompletions;
        _totalCompletionPoints = totalCompletionPoints;
        _currentCompletions = 0;
    }
    public RepeatedGoal(string name, string description, int pointGain, int currentCompletions, int totalCompletions, int totalCompletionPoints,bool isComplete) : base(name, description, pointGain, isComplete)
    {
        _totalCompletions = totalCompletions;
        _totalCompletionPoints = totalCompletionPoints;
        _currentCompletions = currentCompletions;
    }
    public override string StoreGoal()
    {
        return $"r,{GetName()},{GetDescription()},{GetPointGain()},{_currentCompletions},{_totalCompletions},{_totalCompletionPoints},{GetIsComplete()}";
    }
    public override void GoalComplete(ScoreTracker Tracker)
    {
        if (!GetIsComplete())
        {
            _currentCompletions++;
            Console.WriteLine($"GOAL COMPLETED");
            Console.WriteLine($"{GetName()}: {_currentCompletions}/{_totalCompletions}");
            if (_currentCompletions == _totalCompletions)
            {
                Console.WriteLine("CONGRATULATIONS, YOU FINISHED THIS GOAL");
                Console.WriteLine($"POINTS AWARDED: {_totalCompletionPoints}");
                Tracker.AddPoints(_totalCompletionPoints);
                SetComplete();
            }
            else
            {
                Console.WriteLine($"POINTS AWARDED: {GetPointGain()}");
                Tracker.AddPoints(GetPointGain());
            }
        }
        else
        {
            Console.WriteLine("Goal is completed");
        }
        Console.WriteLine("Press enter to continue");
        Console.Read();
    }
    public override void DisplayGoal()
    {
        if (GetIsComplete())
        {
            Console.WriteLine($"{GetName()} {_currentCompletions}/{_totalCompletions}: {GetDescription()}\nType:Repeated\n Each XP: {GetPointGain()} Final XP: {_totalCompletionPoints} ");
        }
        else
        {
        Console.WriteLine($"{GetName()} {_currentCompletions}/{_totalCompletions}: {GetDescription()}\nType:Repeated\n Each XP: {GetPointGain()} Final XP: {_totalCompletionPoints} ");
        }
    }
}