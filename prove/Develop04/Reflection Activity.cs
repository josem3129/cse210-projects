public class reflectionActivity : activityDescription
{
    // here we got two list too
    // one list for the first question 
    // the second is for the list that holds the reflecting questions. 
    private List<string> _thinkPrompt;
    private List<string> _reflectPrompt;

    public void refectionExercise()
    {
        _thinkPrompt = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."

        };

        _reflectPrompt = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"

        };

        DisplayBegeningPrompt("This activity will help you refelct on items in your life when you have shown strength and resilience. This will help oyu recognize the power you have and how you can use it in other aspects of your life.");
        int duration = DurationOfactivity();

        // this finds the current time and add the seconds that user input
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        DateTime currentTime;

        //clear console and displays ready and waits a couple seconds to start.
        Console.Clear();
        Console.WriteLine("Get ready....");
        WaitingTIme(2);

        // chooses a rondome question to begen with 
        Random random = new Random();
        int index = random.Next(0,_thinkPrompt.Count());
        string randomThinkQuestion = _thinkPrompt[index];
        

        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine($"--- {randomThinkQuestion} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        string userContinue = Console.ReadLine();


        //than a if loop to check if user didnt just press enter 
        // if not gives an error 
        if (userContinue == "")
        {
            Console.Write("Now ponder on each of the following questions as they relate to this experience.");
            CountDownPrompt("You may begin in:");
            Console.Clear();
            do
            {
                
                Random random2 = new Random();
                int index2 = random.Next(0,_reflectPrompt.Count());
                string randomReflectionQuestion = _reflectPrompt[index2];
                Console.WriteLine($">{randomReflectionQuestion}");
                WaitingTIme(10);
                currentTime =  DateTime.Now;
                

            }while(currentTime < futureTime);

            Console.WriteLine("Well done!!");
            WaitingTIme(5);
            Console.WriteLine(DisplayUserDuration());
            WaitingTIme(5);
        }
        else if (userContinue != "")
        {
            Console.WriteLine("Incorrect please try again");
            WaitingTIme(2);
        }


    }

}