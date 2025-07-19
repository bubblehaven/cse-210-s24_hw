public class Prompt
{
    public static List<string> _prompts = new List<string>
    {
        "What was the highlight of your day?",
        "What do you think you could have done better today?",
        "What was the hardest thing you did today",
        "What was something you didn't expect today?",
        "Do you see things differently now than you did this morning?"
    };
    public static string GetPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(0, _prompts.Count);
        return _prompts[index];
    }
}