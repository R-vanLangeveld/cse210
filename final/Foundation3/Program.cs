using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("2596 S 90372 W, Dayton, Ohio");
        LectureEvent lectureEvent = new LectureEvent("The Positive and Negitive Effects of Chocolate", "A lecture about the effects that chocolate has on the body.", "Nov 7, 2024", "3:00 PM", lectureAddress, "John K. Smith", 400);
        Console.WriteLine(lectureEvent.StandardDetails());
        Console.WriteLine(lectureEvent.FullDetails());
        Console.WriteLine(lectureEvent.ShortDescription(lectureEvent.GetEventType()));

        Console.WriteLine("\n");

        Address outdoorAddress = new Address("9302 S 1436 W, South Jordan, Utah");
        OutdoorEvent outdoorEvent = new OutdoorEvent("Major League Children's Soccer Game", "Playoffs continue in the Major League Children's Soccer Tournament. Come see your team compete.", "June 21, 2024", "1:30 PM", outdoorAddress, "Clear skies and temptures between 75-82 degrees F");
        Console.WriteLine(outdoorEvent.StandardDetails());
        Console.WriteLine(outdoorEvent.FullDetails());
        Console.WriteLine(outdoorEvent.ShortDescription(outdoorEvent.GetEventType()));

        Console.WriteLine("\n");
        
        Address recptionAddress = new Address("290 S 157 W, Middleton, Idaho");
        ReceptionEvent receptionEvent = new ReceptionEvent("Marrage of Joe Smith and Jane Brown", "Wedding reception for Jane and Joe invite only.", "Aug 17, 2024", "4:30 PM", recptionAddress, "JoeSmith@gmail.com");
        Console.WriteLine(receptionEvent.StandardDetails());
        Console.WriteLine(receptionEvent.FullDetails());
        Console.WriteLine(receptionEvent.ShortDescription(receptionEvent.GetEventType()));
    }
}