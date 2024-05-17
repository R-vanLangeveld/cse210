class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description)
        :base(name, description)
    {
        _prompts = ["Think of a time you stood up for someone else.", 
        "Think of a time when you did something really difficult.", 
        "Think of a time when you helped someone in need.", 
        "Think of a time when you did something truly selfless.", 
        "Think of a time when you received help from another person.", 
        "Think of a time something really funny happened.", 
        "Think of a time when you created something (art, crafts, etc.)."];

        _questions = ["Why was this experience meaningful to you?", 
        "Have you ever done anything like this before?", "How did you get started?", 
        "How did you feel when it was complete?", 
        "What made this time different than other times when you were not as successful?", 
        "What is your favorite thing about this experience?", 
        "What could you learn from this experience that could apply to other situations?", 
        "What did you learn about yourself through this experience?", 
        "How can you keep this experience in mind in the future?"];
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.Write("How long would you like the activiy to be in seconds? (If you decided that you wanted to do a different activity type 0) ");
        string toNumber = Console.ReadLine();
        _duration = int.Parse(toNumber);

        if (_duration != 0)
        {
            DisplayPrompt();
            Console.Write("When you have an answer in mind, press enter to continue");
            Console.ReadLine();
            Console.Write("The activity will begin in: ");
            ShowCountDown(5);
            Console.Clear();
            Console.WriteLine("Ponder each of the follwoing questions as they relate to the prompt\n");
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);
            DateTime currentTime = DateTime.Now;
            
            while (currentTime < endTime)
            {
                DisplayQuestions();
                ShowSpinner(10);
                currentTime = DateTime.Now;
            }
            DisplayEndingMessage();
        }
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0,_prompts.Count);
        return _prompts[index];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(0,_questions.Count);
        return _questions[index];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"Consider the following prompt:\n{GetRandomPrompt()}");
    }
    public void DisplayQuestions()
    {
        Console.Write($"\n{GetRandomQuestion()}");
    }
}