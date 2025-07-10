using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("James", 1, 5, 6);
        Scripture James = new Scripture(ref1,
         @"    For if any of ye lack wisdom, let him ask of God, who giveth to all men liberally,
    and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering.
    For he that wavereth is like a wave of the sea, driven with the wind and tossed.");
        Random rnd = new Random();

        //bool gameRunning = true; 


        Console.WriteLine("Welcome to the Scripture memorizing game!");

        //while (gameRunning == true)//full loop
        {
            Console.WriteLine("Here is the scripture: ");
            Console.WriteLine($"{James.GetReference()}");

            while (James.AllWordsHidden() == false)//individual scripture loop
            {
                foreach (Word w in James.GetWords())
                {
                    Console.Write($"{w.GetDisplayText()} ");
                }
                Console.Write("\nPress Enter to remove more words, or quit to quit ");
                string placeholder = Console.ReadLine();
                if (placeholder == "quit")
                {
                    //gameRunning = false;
                    break;
                }

                Console.Clear();

                int removed_word_count = 0;
                while (removed_word_count < 3 && !James.AllWordsHidden())//hiding words loop
                {
                    foreach (Word w in James.GetWords())
                    {
                        if (!w.IsHidden())
                        {
                            int rand = rnd.Next(1, 3);
                            if (rand == 1)
                            {
                                w.HideWord();
                                removed_word_count++;
                            }

                        }
                    }
                }
            }
            //Scrapped replayability 
            // if (James.AllWordsHidden()) 
            // {
            //     Console.WriteLine("Congrats, would you like to try again? y/n");
            //     string response = Console.ReadLine();
            //     if (response == "y")
            //     {
            //         Console.WriteLine("Alright, lets do that again");
            //         Console.Clear();
            //     }
            //     else
            //     {
            //         gameRunning = false;
            //     }
        }
    }
}


