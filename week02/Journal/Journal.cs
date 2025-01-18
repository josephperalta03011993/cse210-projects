using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {   
            Console.WriteLine("No entries found.");
            return;
        }

        for (int i = 0; i < _entries.Count; i++)
        {
            _entries[i].Display();
        }
    }

    public void SaveToFile(string file)
    {
        string fileName = file;

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {   


            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string fileName = file;
        string[] lines = File.ReadAllLines(fileName);

        foreach(string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            _entries.Add(entry);
        }
    }

    public void SaveAsCSV(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            // write header for the file
            outputFile.WriteLine("Date,Prompt,Entry");

            foreach (Entry entry in _entries)
            {
                string escapedEntry = entry._entryText.Replace("\"", "\"\"");
                if (escapedEntry.Contains(","))
                {
                    escapedEntry = "\"" + escapedEntry + "\"";
                }

                outputFile.WriteLine($"{entry._date},{entry._promptText},{escapedEntry}");
            }
        }
    }
}