using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your journal!");
        

        List<Entry> entries = new List<Entry>();
        Storage storage = new Storage();
        
        bool journalOpen = true;
        while (journalOpen == true)
        {
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Exit");
            Console.WriteLine("What would you like to do?");
            int options = int.Parse(Console.ReadLine());
            if (options == 1)
            {
                //grabs a prompt and holds reply
                string prompt1 = Prompt.GetPrompt();
                Console.WriteLine($"{prompt1}");
                Console.Write(" ");
                string response = Console.ReadLine();
                
                //create entry and add to list
                Entry newEntry = new Entry(prompt1, response);
                entries.Add(newEntry);
                Console.WriteLine("Entry saved!");
            }
            else if (options == 2)//display
            {
                
                if (entries.Count == 0)
                {
                    Console.WriteLine("No entries to display.");
                }
                else
                {
                    Console.WriteLine("\n--- Your Journal Entries ---");
                    foreach (Entry entry in entries)
                    {
                        Console.WriteLine(entry.ToString());
                    }
                }
            }
            else if (options == 3)
            {
                entries = storage.Loadfile();
            }
            else if (options == 4)
            {
                storage.Savefile(entries);
            }
            else if (options == 5)
            {
                journalOpen = false;
            }
            else
            {
                Console.WriteLine("INVALID INPUT");
            }

        }

        // Prompt p = new Prompt();

            // string prompt = p.GetPrompt();
            // Console.WriteLine(prompt);

    }
}