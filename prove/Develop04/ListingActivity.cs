class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    
    public ListingActivity(string name, string description)
        :base(name, description)
    {
        _prompts = ["Who are people you appreciate?","What are some of your personal strengths?",
        "Who are people you have helped this week?","What funny things have happened in the past?", 
        "When have you felt the Holy Ghost this month?", "What are some of your greatest blessings?",
        "Who are some of your personal heroes?", "What about you makes you feel accomplished or proud?"];       
        _count = 0;
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
            GetRandomPrompt();
            Console.Write("The activity will begin in: ");
            ShowCountDown(5);
            Console.Clear();
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);
            DateTime currentTime = DateTime.Now;
            
            while (currentTime < endTime)
            {
                Console.Write("> ");
                Console.ReadLine();
                _count += 1;
                currentTime = DateTime.Now;
            }
            Console.WriteLine($"You have listed {_count} thing(s).");
            DisplayEndingMessage();
        }
    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0,_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }
    public List<string> GetListFromUser()
    {
        return _prompts; // Probably won't stay as _prompts but I needed to put something so there wouldn't 
        // be an error
    }
}