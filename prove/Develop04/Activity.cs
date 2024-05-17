class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name} activity. \n{_description}");
    }
    public void DisplayEndingMessage()
    {
        Thread.Sleep(1000);
        Console.WriteLine($"\n\nWell done. Thank you for doing the {_name} activity. \nPlease continue to be mindful in your daily life.");
    }
    public void ShowSpinner(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            seconds -= 1;
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            seconds -= 1;
        }
    }
    public void ShowCountDown(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            seconds -= 1;
            Console.Write("\b \b");
        }
    }
}