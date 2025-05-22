public class Prompt
{
    public List<string> _prompts = new List<string>
    {
        "What was the highlight of your day?",
        "What do you think you could have done better?",
        "What was the hardest thing you did today"
    };
    public string GetPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(0, _prompts.Count);
        return _prompts[index];
    }
}