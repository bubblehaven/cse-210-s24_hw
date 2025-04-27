using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Grade? (100pt scale) ");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);
        string letter;
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80){
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (grade % 10 >= 7 && grade >= 60){
            letter += "+";
        }
        else if (grade % 10 < 3 && grade != 100 && grade >= 60){
            letter += "-";
        }
        Console.WriteLine($"Your letter grade is {letter}.");
        if (grade >= 70)
        {
            Console.WriteLine("You passed :D");
        }
        else
        {
            Console.WriteLine("You failed. womp womp. do you know what went wrong? \n let's fix that for next time, you got this!");
        }
    }
}