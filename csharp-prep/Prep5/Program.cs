using System;
// functions!!!
class Program
{
    static void DisplayWlcome(){
        Console.WriteLine("Welcome to the program!!!");
    }
    static string PromptUserName(){
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber(){
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number){
        return number*number;
    }
    static void DisplayResult(string name, int squarenum){
        Console.WriteLine($"{name}, your favorite number squared is {squarenum}");
    }
        static void Main(string[] args)
    {
        DisplayWlcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        DisplayResult(name,SquareNumber(number));
    }
}