using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);
        string gradeLetter = "";

        if (gradeNumber >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradeNumber >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradeNumber >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradeNumber >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        Console.WriteLine($"Your grade is {gradeLetter}.");

        if (gradeNumber >= 70)
        {
            Console.Write("Congratulations! You passed the class.");
        }
        else
        {
            Console.Write("Unfortunately you did not pass the class.");
        }
    }
}