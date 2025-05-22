using System.Dynamic;
using System.IO;

public class Entry
{
    List<string> _entries = new List<string>();

    public List<string> GetEntry(List<string> _entries = null)
    {
        if (_entries == null)
        {
            _entries = new List<string>();
        }
        Console.Write("");
        string entry = Console.ReadLine();
        DateTime mydate = new DateTime();
        _entries.Add($"{mydate.Day}/{mydate.Month}/{mydate.Year}");
        _entries.Add(entry);
        return _entries;
    }    
}



