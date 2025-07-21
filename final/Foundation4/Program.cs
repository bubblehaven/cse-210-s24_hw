using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        List<Training> train = new List<Training>();
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Workout Tracker");
            Console.WriteLine("===============");
            Console.WriteLine("1. New Workout\n2. View Workouts\n3. Quit");
            int choice = GetValidatedInt("");
            if (choice == 1)
            {
                Console.Clear();
                int workout = GetValidatedInt("1. Cycling\n2. Running\n3. Swimming\n");
                if (workout == 1)
                {
                    float length = GetValidatedFloat("Enter workout time in minutes: ");
                    float speed = GetValidatedFloat("Enter speed in mph: ");
                    CyclingTraining cycle = new CyclingTraining(length, speed);
                    train.Add(cycle);
                }
                else if (workout == 2)
                {
                    float length = GetValidatedFloat("Enter workout time in minutes: ");
                    float distance = GetValidatedFloat("Enter distance in miles: ");
                    RunningTraining run = new RunningTraining(length, distance);
                    train.Add(run);
                }
                else if (workout == 3)
                {
                    float length = GetValidatedFloat("Enter workout time in minutes: ");
                    int laps = GetValidatedInt("Enter number of laps: ");
                    SwimmingTraining swim = new SwimmingTraining(length, laps);
                    train.Add(swim);
                }
                else
                {
                    Console.WriteLine("Invalid input, enter a value between 1 and 3");
                    Console.ReadLine();
                }
            }
            else if (choice == 2)
            {
                Console.Clear();
                foreach (Training training in train)
                {
                    training.GetSummary();
                }
                Console.Write("Press Enter to exit: ");
                Console.ReadLine();
            }
            else if (choice == 3)
            {
                running = false;
            }
        }
    }
    public static int GetValidatedInt(string prompt)
    {
        int value;
        Console.Write(prompt);
        while (!int.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("INVALID INPUT. Please enter a valid integer: ");
        }
        return value;
    }
    public static float GetValidatedFloat(string prompt)
    {
        float value;
        Console.Write(prompt);
        while (!float.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("INVALID INPUT. Please enter a valid integer: ");
        }
        return value;
    }
}