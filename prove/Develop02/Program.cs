using System;

class Program
{

    static void Main(string[] args)
    {
        bool run = true;


        while (run)
        {
            Menu menu = new Menu();
            GetUserInput input = new GetUserInput();

            menu.Display();

            int choice = input.GetChoice();
            
            switch (choice)
            {
                case 1: 
                    Write write = new Write();
                    string dateText = write.GetDate();
                    

                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
                case 4:
                    
                    break;
                case 5:
                    Console.WriteLine("Come write again, soon!");
                    run = false;
                    break;

                default: 
                    Console.WriteLine($"Your selection of {choice} is not valid. Select a number 1 - 5.");
                    run = true;
                    break;
            }

            
        }

        



        
        
        
    }

    public bool UserClose()
    {
        Console.WriteLine("Come write again, soon!");
        bool run = false;
        return run;
    }
        
            
        
    

}
    



    