using System.Runtime.CompilerServices;

public class Breathing : Activity
{



    public int BreathCount(int duration)
    {
        int breathCount = 0;
        int nextBreathLength = 4;
        int currentBreathLength = 2;

        while (duration >= nextBreathLength + breathCount * 4)
        {
            breathCount -= nextBreathLength;
            breathCount++;
            currentBreathLength++;
            nextBreathLength = currentBreathLength * 2;
        }

        return breathCount;
    }


    public void PerformActivity()
    {
        Console.WriteLine("Welcome to the breathing activity! Here we will take progressively deeper breaths in order to calm down");
        Console.Write("How long would you like this activity to last in seconds? ");
        SetDuration(int.Parse(Console.ReadLine()));
        int totalBreaths = BreathCount(GetDuration());

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(GetDuration());
        Console.WriteLine("\n\n");

        int breathCount = 0;
        while (totalBreaths != breathCount)
        {
            for (int i = 0; i < breathCount + 2; i++)
            {
                Console.SetCursorPosition(0, 1);
                Console.Write($"Breath in {i}");
                Thread.Sleep(1000);
            }
            for (int i = 0; i < breathCount + 2; i++)
            {
                Console.SetCursorPosition(0, 1);
                Console.Write($"Breath out {i}");
                Thread.Sleep(1000);
            }
            breathCount++;

        }
        DateTime currentTime = DateTime.Now;//waits excess time
        while (currentTime < end) {
            Console.Write($".");
            currentTime = DateTime.Now;
        }

        Console.WriteLine($"\n{GetEndMessage()}");
    }
}