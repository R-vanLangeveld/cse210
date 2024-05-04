using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        string separatorLine = "|";
        string separatorEntry = "~";
        string save = "";
        string date = "";
        string prompt = "";
        string response = "";
        File.WriteAllText(file,save);

        foreach (Entry entry in _entries)
        {
            date = entry._date;
            prompt = entry._promptText;
            response = entry._entryText;
            save = date + separatorEntry + prompt + separatorEntry + response + separatorLine + "\n";
            File.AppendAllText(file,save);
        }
    }
    public void AppendToFile(string file)
    {
        string separatorLine = "|";
        string separatorEntry = "~";
        string save = "";
        string date = "";
        string prompt = "";
        string response = "";

        foreach (Entry entry in _entries)
        {
            date = entry._date;
            prompt = entry._promptText;
            response = entry._entryText;
            save = date + separatorEntry + prompt + separatorEntry + response + separatorLine + "\n";
            File.AppendAllText(file,save);
        }
    }
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        string[] read;
        string[] read2;
        var one = new List<string>();
        
        foreach (string line in lines)
        {
            read = line.Split("|");
            one.Add(read[0]);
        }
        foreach (string line in one)
        {
            Entry newEntry = new Entry();
            read2 = line.Split("~");
            newEntry._date = read2[0];
            newEntry._promptText = read2[1];
            newEntry._entryText = read2[2];
            AddEntry(newEntry); 
        }
    }
}