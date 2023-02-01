using System;


public class GetUserInput
{

    public int GetChoice()
        {
            string _userInput = Console.ReadLine();
            int choice = int.Parse(_userInput);
            return choice;
        }
}