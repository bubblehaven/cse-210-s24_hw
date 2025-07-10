using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("joe", "inductors");

        string summary = assignment.GetSummary();

        Console.WriteLine($"{summary}");
    }
}