using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello, what is your grade percentage? ");

        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = "";
        
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade < 90 && grade >= 80)
        {
            letter = "B";
        }
        else if (grade < 80 && grade >= 70)
        {
            letter = "C";
        }
        else if (grade < 70 && grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You grade for this class is {letter}.");

        if (grade < 70)
        {
            Console.WriteLine("Sorry you did not pass the class");
        }
        else
        {
            Console.WriteLine("Congrats you passed the class");
        }
    }
}