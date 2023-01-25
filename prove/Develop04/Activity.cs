public class activityDescription
{
    // This class is the base class it initiate protective variables for the other classes 
    // some of this varibales are the begening prompt and the endeing prompt 
    // another one is the duartion that user enters. 
    protected string _activityPrompt;

    protected int _UserDuration;

    public string GetBegeningPrommpt()
    {
        return _activityPrompt;
    }

    public void SetBegeningPrompt(String activityPrompt)
    {
        _activityPrompt = activityPrompt;
    }

    public int GeUserDuration()
    {
        return _UserDuration;
    }

    public void SetUserDuration(int userDuration)
    {
        _UserDuration = userDuration;
    }

    public activityDescription()
    {
        _UserDuration = 30;
    }

    public string DisplayBegeningPrompt()
    {
        return $"Welcome to the {_activityPrompt}!\n ";
    }

    public string DisplayUserDuration()
    {
        string duration = _UserDuration.ToString();
        return $"You have completed another {duration} second of the {_activityPrompt}";
    }

    // this method does the waiting or loading animation 
    public void WaitingTIme(int _waitDuration)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_waitDuration);
        DateTime currentTime;
        Console.Write("|");

        do
        {
            
            Console.Write("\b \b");
            Console.Write("/"); 
            Thread.Sleep(550);
            Console.Write("\b \b"); 
            Console.Write("_");
            Thread.Sleep(550);
            Console.Write("\b \b"); 
            Console.Write("\\");
            Thread.Sleep(550);
            Console.Write("\b \b"); 
            Console.Write("|");
            
           
            currentTime =  DateTime.Now;
            

        }while(currentTime < futureTime);
        Console.Write("\b \b");
    }

    // this method does wait animation woth numbers. 
    public void CountDownPrompt(string prompt)
    {
        
        Console.Write($"\n{prompt} 4");
        Thread.Sleep(1500);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1500);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1500);
        Console.Write("\b \b");
        Console.Write("1");
        Console.Write("\b \b");
    }
}