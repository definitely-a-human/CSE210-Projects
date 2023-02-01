using System;

class Write
{
    List<string> promptList = new List<string>();
    
    

    public string GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }


    public string ShowPrompt()
    {

    }

    public string GetEntry()
    {

    }
}