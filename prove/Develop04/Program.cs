using System;
// Extra stuff (exceeding requirements)
// Added a new class for another activity GroundingActivity.cs
// In the Grounding activity you will list things you can: see, touch, taste, smell, and hear
class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        do {
            Console.WriteLine("Hello, and welcome to the Mindfulness Program");
            Console.Write("\nMenu Options:\n    1. Breathing Activity\n    2. Listing Activity\n    3. Reflecting Activity\n" 
            + "    4. Grounding Activity\n    5. Quit\nSelect an Activity from the menu: ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                BreathingActivity breathing = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathing.Run();
            }
            else if (option == "2")
            {
                ListingActivity listing = new ListingActivity("Listing", "This activity will help you think about all the good things in your life by having you list as many things as you can based off of a prompt.");
                listing.Run();
            }
            else if ("3" == option)
            {
                ReflectingActivity reflecting = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use that power in other aspects of your life.");
                reflecting.Run();
            }
            else if ("4" == option)
            {
                GroundingActivity grounding = new GroundingActivity("Grounding", "In this activity you will list something you can see, something you can touch, something you can taste, something you can smell, and something you can hear.");
                grounding.Run();
            }
            else if ("5" == option)
            {
                quit = true;
            }
        } while (quit == false);
    }
}