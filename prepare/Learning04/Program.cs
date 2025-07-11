using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("joe", "inductors");

        string summary = assignment.GetSummary();

        Console.WriteLine($"{summary}");

        MathAssignment math = new MathAssignment("Joel Turnfoot", "Limits", "12.1", "6-7");
        Console.WriteLine($"{math.GetSummary()}\n{math.GetHomeworkList()}");

        WritingAssignment writing = new WritingAssignment("Jonathan Browsby", "Classic Works", "Dante's Inferno: The Fiction That Became Doctrine");
        Console.WriteLine($"{writing.GetSummary()}\n{writing.GetWritingInformation()}");
    }
}