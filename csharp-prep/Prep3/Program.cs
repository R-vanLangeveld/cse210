using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int guess = 0;
        
        do 
        {
        Console.Write("What is your guess? ");
        string guessNumber = Console.ReadLine();
        guess = int.Parse(guessNumber);
        
        if (guess < number)
        {
            Console.WriteLine("Your guess is lower than the magic number.");
        }
        else if (guess > number)
        {
            Console.WriteLine("Your guess is higher than the magic number.");
        }
        } while (guess != number);
        Console.WriteLine($"The magic number is {number}");
    }
}