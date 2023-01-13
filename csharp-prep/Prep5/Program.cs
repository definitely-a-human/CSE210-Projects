using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNum = PromptUserNumber();

        int squaredNumber = SquareNumber(userNum);

        DisplayResult(userName, squaredNumber);

    }




    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }


    static string PromptUserName()
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        string userNumber = Console.ReadLine();
        int number = int.Parse(userNumber);

        return number;
    }


    static int SquareNumber(int number)
    {
        int squaredNum = number * number;

        return squaredNum;
    }


    static void DisplayResult(string name, int squaredNum)
    {
        Console.WriteLine($"{name}, your number squared is {squaredNum}.");
    }
}