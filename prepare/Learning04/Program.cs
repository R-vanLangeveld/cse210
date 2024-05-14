using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment();
        assignment1.ConstructAssignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment();
        assignment2.ConstructMathAssignment("section 7.3", "problems 8-19", "Roberto Rodriguez", "Fractions");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment();
        assignment3.ConstructWritingAssignment("The Causes of World War II", "Mary Waters", "European History");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}