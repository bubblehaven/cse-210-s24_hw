using System;
using System.Formats.Asn1;

// number guessing game
class Program
{
    static void Main(string[] args)
    {
        bool gamerunning = true;
        while (gamerunning == true){
            Random rnd = new Random(); 
            int magicnum = rnd.Next(1,100);
            Console.Write("What is the magic number?");
            string stringguess = Console.ReadLine();
            int guess = int.Parse(stringguess);
            int guesscount = 1;

                while (guess != magicnum){
                if (guess < magicnum){
                    Console.WriteLine("Higher");
                }
                else if (guess > magicnum){
                    Console.WriteLine("Lower");
                }
                else{
                    Console.WriteLine("That's not a number");
                }
                Console.Write("What is the magic number?");
                stringguess = Console.ReadLine();
                guess = int.Parse(stringguess);
                guesscount++;
                }
        Console.WriteLine("You guessed the magic number!");
        Console.WriteLine($"You got it in {guesscount} guesses");
    Console.Write("Do you want to play again?");
    string answer = Console.ReadLine();
    if (answer == "no"){
        gamerunning = false;
    }
    else{
        Console.WriteLine("I'll take that as a yes \n");
    }}
    Console.WriteLine("Game Ended");
    }
}