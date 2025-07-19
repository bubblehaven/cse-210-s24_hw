using System;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        ScoreTracker tracker = new ScoreTracker();
        SaveLoad sl = new SaveLoad("GoalTracker");
        List<Goal> list = new List<Goal>();
        while (running)
        {
            tracker.CheckLevel();

            Console.WriteLine($"ADVENTURES IN GOALING     lvl: {tracker.GetLevel()}");
            Console.Write("1.New Goal\n2.View Goals\n3.Save\n4.Load\n5.Quit\n ");
            bool success = int.TryParse(Console.ReadLine(), out int choice);
            if (success && choice < 7 && choice > 0)
            {
                Console.Clear();
                if (choice == 1)
                {
                    Console.Write("1. One Time Goal\n2. Repeated Goal\n3.Eternal Goal\n4. Back");
                    bool success2 = int.TryParse(Console.ReadLine(), out int choice2);
                    if (success2 && choice2 <= 3 && choice2 >= 1)
                    {
                        Console.Clear();
                        if (choice2 == 1)
                        {
                            Console.Write("Enter Goal Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter a brief description of your goal: ");
                            string description = Console.ReadLine();
                            int pointGain = GetValidatedInt("Enter xp reward: ");
                            Goal goal = new Goal(name, description, pointGain);
                            list.Add(goal);
                        }
                        if (choice2 == 2)
                        {
                            Console.Write("Enter Goal Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter a brief description of your goal: ");
                            string description = Console.ReadLine();
                            int totalCompletions = GetValidatedInt("Enter the number of times you will complete this goal: ");
                            int pointGain = GetValidatedInt("Enter the xp gain from completing this goal once: ");
                            int totalPointGain = GetValidatedInt($"Enter the xp gain from completing goal {totalCompletions} times: ");
                            RepeatedGoal goal = new RepeatedGoal(name, description, pointGain, totalCompletions, totalPointGain);
                            list.Add(goal);
                        }
                        if (choice2 == 3)
                        {
                            Console.Write("Enter Goal Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter a brief description of your goal: ");
                            string description = Console.ReadLine();
                            int pointGain = GetValidatedInt("Enter xp reward: ");
                            EternalGoal goal = new EternalGoal(name, description, pointGain);
                            list.Add(goal);
                        }
                    }
                }
                else if (choice == 2)
                {
                    for (int i = 0; i < list.Count(); i++)
                    {
                        Console.Write($"{i + 1}: ");
                        list[i].DisplayGoal();
                    }
                    int choice3 = GetValidatedInt("Select goal to complete, or 0 to exit: ");
                    if (choice3 != 0 && choice3 <= list.Count())
                    {
                        Console.Clear();
                        list[choice3 - 1].GoalComplete(tracker);
                    }
                    else if (choice3 != 0)
                    {
                        Console.WriteLine("INVALID INPUT");
                    }
                }
                else if (choice == 3)
                {
                    Console.Write("Enter file name: ");
                    sl.SetFileName(Console.ReadLine());
                    sl.SaveFile(list, tracker);
                }
                else if (choice == 4)
                {
                    Console.Write("Enter file name: ");
                    sl.SetFileName(Console.ReadLine());
                    sl.LoadFile(tracker,list);
                }
                else if (choice == 5)
                {
                    running = false;
                }
            }
            else
            {
                Console.WriteLine("INVALID INPUT");
                Thread.Sleep(3000);
            }
            Console.Clear();
        }
        ;
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
}