public class ListingActivity : Activity
{
    private List<string> _listingPrompts;
    public ListingActivity() : base()
    {
        _listingPrompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public string GetPrompt(int index)
    {
        return _listingPrompts[index];
    }

    public void PerformActivity()
    {
        Console.WriteLine("Welcome to the listing activity. In this activity you will be given one prompt, and list as many answers to that prompt as you can");
        SetDuration();

        Random rand = new Random();
        string prompt = GetPrompt(rand.Next(0, 4));
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        DateTime currentTime = startTime;
        int answerCount = 0;

        while (currentTime < endTime)
        {
            Console.Write(prompt);
            Console.ReadLine();
            answerCount++;
            currentTime = DateTime.Now;
        }

        Console.WriteLine(GetEndMessage());
        Thread.Sleep(3000);
    }
}