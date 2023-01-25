public class listingActivity : activityDescription
{
    // this are the list we need for user and promt 
    // when user enters a promt is saved in list 
    // then is shown how many are in list
    private List<string> _promptList;

    private List<string> _userPormpts;

    public void ListingExercise()
    {
        _userPormpts = new List<string>();
        _promptList = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random random = new Random();
        int index = random.Next(0,_promptList.Count());
        string randomQuestion = _promptList[index];
        
        //begening prompt
        Console.Clear();
        Console.WriteLine(DisplayBegeningPrompt());

        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certin area./n");
        Console.Write("How long, in seconds, would you like for your session? ");
      
        string duration = Console.ReadLine();
        _UserDuration = int.Parse(duration);

        Console.Clear();


        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_UserDuration);
        DateTime currentTime;

        //clear console and displays ready and waits a couple seconds to start.
        Console.Clear();
        Console.WriteLine("Get ready....");
        WaitingTIme(5);


        // loop though the listing exercise as long the user inputed
        // every time it loops itchecks time to stop for how long
        // prompts randome question from list 
        Console.WriteLine("List as many responses you can to the fallowing prompt:");
        Console.Write($"==={randomQuestion}===");
        CountDownPrompt("You may begin in:");
        Console.WriteLine();
        
        do
        {

            Console.Write(">");
            string reflection = Console.ReadLine();
            _userPormpts.Add(reflection);
            
            currentTime =  DateTime.Now;
            

        }while(currentTime < futureTime);

        //ending prompt. 

        Console.WriteLine("Well done!!");
        WaitingTIme(2);
        int count = _userPormpts.Count();
        Console.WriteLine($"You listed {count} items!");
        WaitingTIme(2);
        Console.WriteLine(DisplayUserDuration());
        WaitingTIme(6);



    }
}