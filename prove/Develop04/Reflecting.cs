public class ReflectingActivity : Activity
{
    private List<string> _reflectPrompts;

    private List<string> _questions;

    public ReflectingActivity():base()
    {
        _reflectPrompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience?",
            "What did you learn about yourself?",
            "How can you apply this experience in the future?"
        };

    }

    public string GetPrompt(int index)
    {
        return _reflectPrompts[index];
    }
    public string GetQuestion(int index)
    {
        return _questions[index];
    }

    public void PerformActivity()
    {
        Console.WriteLine("Welcome to the Reflecting activity. Here you will reflect on something, then have some time to answer some questions about it.");

        Random rand = new Random();
        SetDuration();

        Console.WriteLine(GetPrompt(rand.Next(0, 4)));
        Console.Write("Press any key when you are ready to continue");
        Console.ReadLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        DateTime currentTime = startTime;

        while (currentTime < endTime)
        {
            Console.WriteLine(GetQuestion(rand.Next(0, 9)));
            Console.WriteLine("\n");
            Spinner(15, 0, 5);
            currentTime = DateTime.Now;
        }

        Console.WriteLine(GetEndMessage());
        Thread.Sleep(3000);

    }
    
}