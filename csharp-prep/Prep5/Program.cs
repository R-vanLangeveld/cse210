using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromtpUserNumber();
        int squared = SquareNumber(number);
        DisplayResult(name, squared);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromtpUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string numberText = Console.ReadLine();
        int number = int.Parse(numberText);
        return number;
    }

    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }

    static void DisplayResult(string name, int squared)
    {
        Console.Write($"{name}, the square of your favorite number is {squared}");
    }
}