using System;
using System.Runtime.CompilerServices;
// Exceeding Requirements
// added a Console.WriteLine that gets a randomly selected encouraging sentence.

// added the function Erase to the Program class that starts hiding the words so that I can call a 
// function and not have a lot of repeating code.
class Program
{
    // Exceeding Requirements
    static void Erase(Scripture newScript)
    {
        string wordsToHide;
        int numberOfWordsToHide;
        string endProgram = "start";
        Console.Write("\nType the ammount of words would you like to hide each loop: ");
        wordsToHide = Console.ReadLine();
        numberOfWordsToHide = int.Parse(wordsToHide);
        
        do 
        {
            Console.Clear();
            newScript.HideRandomWords(numberOfWordsToHide);
            Console.WriteLine(newScript.GetDisplayText());
            
            if (newScript.IsCompletelyHidden() == true)
            {
                endProgram = "quit";
            }
            else
            {
                Console.Write("\nPress the enter key to continue to hide words or type quit to end the session: ");
                endProgram = Console.ReadLine();
            }
        } while (endProgram.ToLower() != "quit");
    }
    static void Main(string[] args)
    {
        Console.Clear();
        
        string book = "";
        int chapter;
        int startVerse; 
        int endVerse = 0;
        string verse;
        string[] words;
        var bookSplit = new List<string>();
        string[] referenceSplit1;
        string[] referenceSplit2;
        string[] referenceSplit3;

        Console.Write("Welcome to Scripture Memorizer! \n"+
        "Would you like to type your own scripture or use the default one?(type custom or default) ");
        string pick = Console.ReadLine();
        if (pick.ToLower() == "custom")
        {
            Console.Write("Please type the scripture reference: ");
            string scriptureReference = Console.ReadLine();
            referenceSplit1 = scriptureReference.Split(":");
            referenceSplit3 = referenceSplit1[0].Split(" ");
            
            int count = 0;
            foreach (string value in referenceSplit3)
            {           
                bookSplit.Add(value);
            }
            count = bookSplit.Count();
            chapter = int.Parse(bookSplit[count-1]);

            bookSplit[count-1] = "";
            string space = " ";
            for (int i = 0; i < count-1; i++)
            {
                book = book + bookSplit[i] + space;
            }
            book = book + bookSplit[count-1];
            
            // use try/catch to check for "-" in reference given from user
            try 
            {
                referenceSplit2 = referenceSplit1[1].Split("-");
                startVerse = int.Parse(referenceSplit2[0]);
                endVerse = int.Parse(referenceSplit2[1]);
            }
            catch (Exception)
            {
                startVerse = int.Parse(referenceSplit1[1]);
            }

            Console.Write("Please type the scripture verse(s): ");
            verse = Console.ReadLine();

            // split user input verse(s) by space
            words = verse.Split(" ");
            Scripture newScript = new Scripture();

            if (endVerse == 0)
            {
                Reference reference = new Reference();
                reference.References(book, chapter, startVerse);
                newScript.Scriptures(reference, words);
                Console.WriteLine(newScript.GetDisplayText());
            }
            else if (endVerse !=0)
            {
                Reference reference = new Reference();
                
                reference.References(book, chapter, startVerse, endVerse);
                newScript.Scriptures(reference, words);
                Console.WriteLine(newScript.GetDisplayText());
                }
            Erase(newScript);
        }
        // use a default scripture for memorization
        else if (pick.ToLower() == "default")
        {
            book = "The Articles of Faith ";
            chapter = 1;
            startVerse = 1;
            verse = "We believe in God, the Eternal Father, and in His Son, Jesus Christ, and in the Holy Ghost.";
            words = verse.Split(" ");
            
            Reference reference = new Reference();
            Scripture newScript = new Scripture();
            reference.References(book, chapter, startVerse);
            newScript.Scriptures(reference, words);
            Console.WriteLine(newScript.GetDisplayText());
            
            Erase(newScript);
        }
        // Exceeding Requirements
        // added a Console.WriteLine that gets a randomly selected encouraging sentence.
        List<string> encourage = new List<string>();
        encourage = ["Hope to see you again soon!","Remember, practicing daily will give you the best results.","Practice makes proficient!"];
        Random randomMessage = new Random();
        int index = randomMessage.Next(encourage.Count);
        string prompt = encourage[index];
        Console.WriteLine("\n" + prompt);
    }
}