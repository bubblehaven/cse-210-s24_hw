using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 1;
        List<int> numberlist = [];
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        while (number != 0){
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0){
                numberlist.Add(number);
            }
        }
        int sum = 0;
        int highestnum = 0;
        foreach (int n in numberlist){
            sum += n;
            if (n > highestnum){
                highestnum = n;  
            }
        }
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average value was {sum/numberlist.Count}");
        Console.WriteLine($"The highest number was {highestnum}!");
    }
// test
    }