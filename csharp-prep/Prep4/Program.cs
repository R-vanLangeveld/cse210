using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number = 1;
        int numberSum = 0;
        int largestNumber = 0;
        do 
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            numbers.Add(number);
            numberSum += number;
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        } while (number != 0);
        float numberAverage = ((float)numberSum) / (numbers.Count - 1);
        Console.WriteLine($"The sum is: {numberSum}");
        Console.WriteLine($"The average is: {numberAverage}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}