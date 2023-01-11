using System;

class Program
{
    static void Main(string[] args)
    {
       

       Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int userNumber = -1;

    while (userNumber != number)
    {
        Console.Write("What is the magic number? ");
        userNumber = int.Parse(Console.ReadLine());
        


            if (userNumber > number)
            {
                Console.WriteLine("Lower");
            }
            else if (userNumber < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it.");
            }
    }

        
}


}