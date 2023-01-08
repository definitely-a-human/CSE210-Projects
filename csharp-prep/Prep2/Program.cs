using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
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


        Console.WriteLine();
        Console.WriteLine($"You have earned the grade of {letter}.");


        if (grade >= 70)
        {
            
            Console.WriteLine("You have passed! Great Job!");
        }
        else
        {
            Console.WriteLine("You did not pass. You got this next time. Keep going!");
        }
    }
}