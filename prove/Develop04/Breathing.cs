using System.Runtime.CompilerServices;

public class BreathingActivity : Activity
{


    public void PerformActivity()
    {
        Console.WriteLine("Welcome to the breathing activity! Here we will take progressively deeper breaths in order to calm down");
        SetDuration();
        int duration = GetDuration();
        Console.Clear();

        int inOutLength = 2;
        int maxInOut = 8;
        int timeElapsed = 0;

        while (timeElapsed + inOutLength * 2 <= duration)
        {
            for (int i = inOutLength; i > -1; i--)
            {
                Console.SetCursorPosition(0, 1);
                Console.Write($"Breath in {i}    ");
                Thread.Sleep(1000);
            }
            for (int i = inOutLength; i > -1; i--)
            {
                Console.SetCursorPosition(0, 1);
                Console.Write($"Breath out {i}   ");
                Thread.Sleep(1000);
            }

            timeElapsed += inOutLength * 2;
            if (inOutLength < maxInOut)
                inOutLength++;
        }

        DateTime end = DateTime.Now.AddSeconds(duration - timeElapsed);
        while (DateTime.Now < end)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }

        Console.WriteLine($"\n{GetEndMessage()}");
        Thread.Sleep(3000);
        }
}