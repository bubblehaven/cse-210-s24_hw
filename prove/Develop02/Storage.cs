using System;
using System.IO;
using System.Collections.Generic;

public class Storage
{
    public List<Entry> Loadfile()
    {
        Console.Write("File name: ");
        string filename = Console.ReadLine();
        List<Entry> entries = new List<Entry>();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                Entry entry = new Entry(parts[0], parts[1], parts[2]);
                entries.Add(entry);
            }
        }
        return entries;
    }
    public void Savefile(List<Entry> entries)
    {
        Console.Write("Save as: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry.StoreEntry());
            }
        }
        Console.WriteLine("File saved successfully!");
    }
}
