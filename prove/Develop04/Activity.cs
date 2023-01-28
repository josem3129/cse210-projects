public class activityDescription
{
    // This class is the base class it initiate protective variables for the other classes 
    // some of this varibales are the begening prompt and the endeing prompt 
    // another one is the duartion that user enters. 
    private string _activityName;

    protected string _UserDuration;
    protected List<int> _durationList= new List<int>();

    public string GetBegeningPrommpt()
    {
        return _activityName;
    }

    public void SetBegeningPrompt(String activityPrompt)
    {
        _activityName = activityPrompt;
    }

    public string GeUserDuration()
    {
        return _UserDuration;
    }

    public void SetUserDuration(string userDuration)
    {
        _UserDuration = userDuration;
    }

    public activityDescription()
    {
        _UserDuration = "30";
        _activityName = "unknown";
    }
    public activityDescription(string activityName)
    {
        
        _activityName = activityName;
    }

    public void DisplayBegeningPrompt(string activityPrompt)
    {
         // clears console then welcomes user with a pormpt and ask how long (in seconds) they would like to run this activity
        Console.Clear();
        Console.WriteLine($"Welcome to {_activityName}");
        Console.WriteLine(activityPrompt);
        Console.Write("How long, in seconds, would you like for your session? ");
    }

    public int DurationOfactivity()
    {
        _UserDuration = Console.ReadLine();

        int newNUm = int.Parse(_UserDuration);

        _durationList.Add(newNUm);

        return newNUm;
    }
    public string DisplayUserDuration()
    {
        string duration = _UserDuration.ToString();
        return $"You have completed another {duration} second of the {_activityName}";
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
            Thread.Sleep(550);
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
    public int DurationOfActivity()
    {
        int durationNUm = int.Parse(_UserDuration);
        int total = durationNUm;
        return total;
    }
}