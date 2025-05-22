using System;
using System.Formats.Asn1;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Xml;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        List<Prompt> _p = new List<Prompt>();
        Console.WriteLine("Welcome to your journal!");
        bool journalOpen = true;
        while (journalOpen == true)
        {
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Exit");
            Console.WriteLine("What would you like to do?");
            int option1 = int.Parse(Console.ReadLine());
            if (option1 == 1)
            {
                _p = Getprompt();
                Console.WriteLine(Getprompt());
            }
            else if (option1 == 2)
            {

            }
            else if (option1 == 3)
            {

            }
            else if (option1 == 4)
            {

            }
            else if (option1 == 5)
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