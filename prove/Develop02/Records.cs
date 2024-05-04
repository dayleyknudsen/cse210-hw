public class Records
{
    private List<Record> _entries;

    public Records()
    {
        _entries = new List<Record>();
    }
    public void AddEntry(Record newEntry)
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
    public void SaveToFile(string filename)
    { }
    public void LoadFromFile(string filename)
    { }
}