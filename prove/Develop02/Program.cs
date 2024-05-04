using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //What I did to exceed requirements

        //Added the option to AppendToFile which will add all entries to an existing file
        
        //Changed the order of menu options to be
        //1. Write 
        //2. Display 
        //3. Save (overwrites file with same name) 
        //4. Append (adds to file with same name) 
        //5. Load 
        //6. Quit

        //To encourage users to keeep writing in the journal
        //I made it say "See you tomorrow!" after the user types 6
        int menu = 0;
        Journal journal = new Journal();
        RandomPrompt prompt = new RandomPrompt();
        prompt._prompts.Add("One thing I am greatful for is:");
        prompt._prompts.Add("My happiest memory from today is:");
        prompt._prompts.Add("A struggle I had this week was:");
        prompt._prompts.Add("A crazy thing that happened today was:");
        prompt._prompts.Add("Something I celebrated this month was:");
        do
        {
            Console.WriteLine("1. Write\n2. Display\n3. Save (overwrites file with same name)\n4. Append (adds to file with same name)\n5. Load\n6. Quit");
            Console.Write("Select an option ");
            string input = Console.ReadLine();
            menu = int.Parse(input);
            if (menu == 1)
            {
                Entry newEntry = new Entry();
                newEntry._promptText = prompt.GetRandomPrompt();
                Console.Write($"\n{newEntry._promptText}\n> ");
                newEntry._entryText = Console.ReadLine();
                newEntry._date = DateTime.Now.ToString("d");
                journal.AddEntry(newEntry);
                Console.WriteLine("");
            }
            else if (menu ==2)
            {
                journal.DisplayAll();
                Console.WriteLine("");
            }
            else if (menu ==3)
            {
                Console.WriteLine("\nIf the filename doesn't exist a new file will be created\nEnter the full file name (example C:\\filename.txt)");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
                Console.WriteLine("");
            }
            else if (menu ==4)
            {
                Console.WriteLine("\nIf the filename doesn't exist a new file will be created\nEnter the full file name (example C:\\filename.txt)");
                string file = Console.ReadLine();
                journal.AppendToFile(file);
                Console.WriteLine("");
            }
            else if (menu ==5)
            {
                journal._entries.Clear();
                Console.WriteLine("\nEnter the full file name (example C:\\filename.txt)");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
                Console.WriteLine("File loaded\n");
            }
        } while (menu != 6);
    Console.WriteLine("See you tomorrow!");
    }
}