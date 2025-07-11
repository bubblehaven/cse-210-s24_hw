using System.Dynamic;

public class Assignment
{
    private string _studentname;
    private string _topic;

    public Assignment(string name, string topic)
    {
        _studentname = name;
        _topic = topic;
    }
    public string GetStudentName()
    {
        return _studentname;
    }
    public string GetSummary()
    {
        return $"{_studentname}'s assignment about {_topic}";
    }
}