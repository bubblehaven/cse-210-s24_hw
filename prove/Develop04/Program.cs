using System;
using System.Security.AccessControl;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        bool appRunning = true;
        while (appRunning)
        {
            Console.Clear();
            Console.WriteLine("Mindfullness Activities");
            Console.WriteLine("=======================");
            Console.WriteLine("1. Breathing Activity\n2.Reflecting\n3.Listing Activity\n4. Quit ");

            bool success = int.TryParse(Console.ReadLine(), out int choice);
            if (success)
            {
                if (choice == 1)
                {
                    Console.Clear();
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.PerformActivity();
                }
                else if (choice == 2)
                {
                    Console.Clear();
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.PerformActivity();
                }
                else if (choice == 3)
                {
                    Console.Clear();
                    ListingActivity listing = new ListingActivity();
                    listing.PerformActivity();
                }
                else if (choice == 4)
                {
                    appRunning = false;
                }
                else
                {
                    Console.Write("INVALID INPUT");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.Write("INVALID INPUT");
                Console.ReadLine();
            }
        }
        Console.WriteLine("Have a Good Day!");
    }
}