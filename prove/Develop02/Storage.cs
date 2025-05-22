using System;
using System.IO;

public class Storage
{
    string _filename;


    public List<string> loadfile()
    {
        Console.Write("File name: ");
        string _filename = Console.ReadLine();
        if (File.Exists(_filename))
        {
            List<string> _entries = new List<string>(File.ReadAllLines(_filename));
            Console.WriteLine("File is loaded");
            return _entries;
        }
        else
        {
            Console.WriteLine("File does not exist");
            return null;
        }
    }

    public void savefile(List<string> _entries)
    {
        Console.Write("Save as: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFIle = new StreamWriter(filename))
        {
            foreach (string l in _entries)
            {
                outputFIle.WriteLine(l);
            }
        }
    }

    public void displayfile(List<string> _entries)
    {
        foreach (string i in _entries)
        {
            Console.WriteLine(i);
        }
    }
    }
