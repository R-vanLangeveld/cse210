public class RandomPrompt
{
    public List<string> _prompts = new List<string>();
    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }
}