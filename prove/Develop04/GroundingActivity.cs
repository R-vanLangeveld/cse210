class GroundingActivity : Activity
{
    public GroundingActivity(string name, string description)
        :base(name, description)
    {
    
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.WriteLine("You can list multiple things or one thing if you can see, touch, taste, smell, and hear it");
        Console.Write("How long would you like the activiy to be in seconds(I highly recommend doing a multiple of 50)? (If you decided that you wanted to do a different activity type 0) ");
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
                Console.Write("Something you can see: ");
                Console.ReadLine();
                Console.Write("Something you can touch: ");
                Console.ReadLine();
                Console.Write("Something you can taste: ");
                Console.ReadLine();
                Console.Write("Something you can smell: ");
                Console.ReadLine();
                Console.Write("Something you can hear: ");
                Console.ReadLine();
                currentTime = DateTime.Now;
            }
            DisplayEndingMessage();
        }
    }
}