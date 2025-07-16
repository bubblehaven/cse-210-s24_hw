public class Activity
{
    protected string _summary;
    private string _endMessage;
    private int _duration;

    public Activity()
    {
        _endMessage = "That's all for now, I hope you're feeling more relaxed now :)";
    }

    public void SetDuration()
    {
        while (true)
        {
            Console.Write("How long would you like this activity to last?");
            if (int.TryParse(Console.ReadLine(), out int duration)&& duration > 0)
            {
                _duration = duration;
                break;
            }
            else
            {
                Console.WriteLine("INVALID INPUT");
            }
        }
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void Spinner(int seconds, int posx, int posy)
    {
        for (int j = 0; j < seconds; j++)
            foreach (char i in "/-\\|/-\\|")
            {
                Console.SetCursorPosition(posx, posy);
                Console.Write($"{i}");
                Thread.Sleep(125);
            }
        Console.SetCursorPosition(posx, posy);
        Console.Write(" \n");
    }
    public string GetEndMessage()
    {
        return _endMessage;
    }
    
}