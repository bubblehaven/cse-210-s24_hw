using System.Drawing;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int pointGain) : base(name, description, pointGain)
    { }
    public override string StoreGoal()
    {
        return $"e,{GetName},{GetDescription},{GetPointGain}";
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"{GetName()}: {GetDescription()}");
        Console.WriteLine($"Type: Eternal\nXP:{GetPointGain()}");
    }
    public override void GoalComplete(ScoreTracker tracker)
    {
        Console.WriteLine("GOAL COMPLETED");
        Console.WriteLine($"{GetName()}: {GetDescription()}");
        Console.WriteLine($"POINTS AWARDED: {GetPointGain()}");
        tracker.AddPoints(GetPointGain());
        Console.WriteLine("Press enter to continue");
        Console.Read();
    }
    



}
