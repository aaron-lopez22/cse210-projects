using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int userNumber = -1;

    while (userNumber != 0)
    {
        Console.Write("Enter Number ");
        userNumber = int.Parse(Console.ReadLine());



    if (userNumber != 0)

        numbers.Add(userNumber);


    }


foreach (float number in numbers)
{
    Console.WriteLine(number);
}

float total = 0;

foreach (float number in numbers)
{
    total += number;
}
float maximumNumber = numbers[0];

foreach (float number in numbers)
{
    if (number > maximumNumber)
    {
        maximumNumber = number;
    }
}

    Console.WriteLine($"The sum is: {total}");

    float average = total / numbers.Count;
    Console.WriteLine($"The average is {average}");

    Console.WriteLine($"The largest number is {maximumNumber}");

}



}