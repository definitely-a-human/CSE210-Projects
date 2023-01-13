using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = 1;



        while (userNumber != 0)
        {
            Console.Write("Enter a whole number. (Enter 0 to end) ");
            string numberInput = Console.ReadLine();
            userNumber = int.Parse(numberInput);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of your numbers is: {sum}.");



        float avg = (float)sum / numbers.Count;
        Console.WriteLine($"The average of your numbers is: {avg}.");



        int max = numbers.Max();
        Console.WriteLine($"The largest number you gave was: {max}.");

        int min = numbers.Min();
        Console.WriteLine($"The lowest number you gave was: {min}.");




        numbers.Sort();
        Console.WriteLine("Your sorted list is:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}