using System.IO;
public class SaveLoad
{
    public string _fileName;
    public SaveLoad(string fileName)
    {
        _fileName = $"{fileName}.txt";
    }
    public void SetFileName(string fileName)
    {
        _fileName = fileName;
    }
    public string GetFileName()
    {
        return _fileName;
    }

    public void SaveFile(List<Goal> goals,ScoreTracker tracker)
    {
        using (StreamWriter outputfile = new StreamWriter(_fileName))
        {
            outputfile.WriteLine($"score,{tracker.GetPoints()}");
            foreach (Goal g in goals)
            {
                outputfile.WriteLine(g.StoreGoal());
            }
        }
    }
    public List<Goal> LoadFile(ScoreTracker tracker, List<Goal> goals)
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Goal goal = null;
            if (parts[0] == "g")
            {
                goal = new Goal(parts[1], parts[2], int.Parse(parts[3]));
            }
            else if (parts[0] == "e")
            {
                goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
            }
            else if (parts[0] == "r")
            {
                goal = new RepeatedGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[4]), int.Parse(parts[6]));
            }
            else if (parts[0] == "score")
            {
                tracker.SetPoints(int.Parse(parts[1]));
            }

            if (goal != null)
                {
                    goals.Add(goal);
                }
        }
        return goals;

    }
}