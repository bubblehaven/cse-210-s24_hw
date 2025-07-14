public class Activity
{
    protected string _summary;
    private string _endMessage;
    private int _duration;

    public Activity()      
    {
        _endMessage = "I hope you're feeling more relaxed now :)";
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public string GetEndMessage()
    {
        return _endMessage;
    }
   
    
}