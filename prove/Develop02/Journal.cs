using System.Threading.Tasks.Dataflow;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    

    public void AddEntry(Entry newEntry)
    {
       _entries.Add(newEntry); 
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
        
    }

    public void LoadFromFile(string file)
    {
       try
       {
            string[] lines = System.IO.File.ReadAllLines(file);
            if (lines.Length != 0)
            {
                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");
                    string date = parts[0];
                    string prompt = parts[1];
                    string entry = parts[2];
                    Entry newLoadEntry = new Entry();
                    newLoadEntry._date = date;
                    newLoadEntry._promptText = prompt;
                    newLoadEntry._entryText = entry;
                    AddEntry(newLoadEntry);
                }
            }
            else
            {
                Console.WriteLine("You currently don't have any entries to display");
            }     
       } 
       catch
       {
            Console.WriteLine("ERROR: Could not find the file.");
       }
    }

}