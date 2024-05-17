class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description)
        :base(name, description)
    {
    
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
            Console.Write("The activity will begin in: ");
            ShowCountDown(5);
            Console.Clear();
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);
            DateTime currentTime = DateTime.Now;
            
            while (currentTime < endTime)
            {
                Console.Write("\n\nBreath in...");
                ShowCountDown(4);
                Console.Write("\nBreath out...");
                ShowCountDown(6);
                currentTime = DateTime.Now;
            }
            DisplayEndingMessage();
        }
    }
}