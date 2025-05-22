using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fract1 = new Fraction();

        Fraction fract2 = new Fraction(6);

        Fraction fract3 = new Fraction(6, 7);

        Fraction fract4 = new Fraction(3, 4);

        Console.WriteLine($"Step 4: {fract1.GetFractionString()} and {fract2.GetFractionString()} and {fract3.GetFractionString()}");

        Console.WriteLine($"Step 5: {fract3.GetTop()} and {fract3.GetBottom()}\nShould be: 6 and 7");

        Console.WriteLine($"Step 6: {fract4.GetFractionString()}");
        Console.WriteLine($"        {fract4.GetFractionDec()}");


    }
}