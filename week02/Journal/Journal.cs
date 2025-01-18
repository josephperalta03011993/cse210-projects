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
            outputFile.WriteLine(_entries);
        }
    }

    public void LoadFromFile(string file)
    {

    }
}