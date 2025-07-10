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
            
            // Convert file data back to Entry objects
            for (int i = 0; i < lines.Length; i += 3) // Each entry takes 3 lines
            {
                if (i + 2 < lines.Length)
                {
                    string dateStr = lines[i];
                    string prompt = lines[i + 1];
                    string response = lines[i + 2];
                    
                    // Create new Entry object
                    Entry entry = new Entry(prompt, response);
                    // Set the date from the file
                    if (DateTime.TryParse(dateStr, out DateTime date))
                    {
                        entry.Date = date;
                    }
                    entries.Add(entry);
                }
            }
            Console.WriteLine("File loaded successfully!");
            return entries;
        }
        else
        {
            Console.WriteLine("File does not exist");
            return new List<Entry>();
        }
    }

    public void Savefile(List<Entry> entries)
    {
        Console.Write("Save as: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                // Save each entry as: date, prompt, response (3 lines)
                outputFile.WriteLine(entry.Date.ToString());
                outputFile.WriteLine(entry.Prompt);
                outputFile.WriteLine(entry.Response);
            }
        }
        Console.WriteLine("File saved successfully!");
    }

    public Entry ConvertFileToEntry(string filename)
    {
        if (File.Exists(filename))
        {
            try
            {
                string content = File.ReadAllText(filename);
                string prompt = $"File: {filename}";
                string response = content;
                
                Entry entry = new Entry(prompt, response);
                entry.Date = DateTime.Now;
                
                Console.WriteLine($"File '{filename}' converted to entry successfully!");
                return entry;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
                return null;
            }
        }
        else
        {
            Console.WriteLine($"File '{filename}' does not exist.");
            return null;
        }
    }

    public void Displayfile(List<Entry> entries)
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
        }
        else
        {
            Console.WriteLine("\n--- Loaded Journal Entries ---");
            foreach (Entry entry in entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }
    }
}
