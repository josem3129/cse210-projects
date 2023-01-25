public class breathingActivity : activityDescription
{
    public breathingActivity(): base()
    {

    }
    public void BreathingExercise() 
    {
        // clears console then welcomes user with a pormpt and ask how long (in seconds) they would like to run this activity
        Console.Clear();
        Console.WriteLine(DisplayBegeningPrompt());

        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n");

        Console.Write("How long, in seconds, would you like for your session? ");
        string duration = Console.ReadLine();

        _UserDuration = int.Parse(duration);

        // this finds the current time and add the seconds that user input
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_UserDuration);
        DateTime currentTime;

        //clear console and displays ready and waits a couple seconds to start.
        Console.Clear();
        Console.WriteLine("Get ready....");
        WaitingTIme(3);

        // loop though the breathing exercise as long the user inputed
        // every time it loops itchecks time to stop for how long 
        do
        {
            CountDownPrompt("Breath in......");

            CountDownPrompt("Now breath out......");
            
            Console.WriteLine("");
            currentTime =  DateTime.Now;
            

        }while(currentTime < futureTime);

        // here we are calling the display method from the activity class. 

        Console.WriteLine("Well done!!");
        WaitingTIme(5);
        Console.WriteLine(DisplayUserDuration());
        WaitingTIme(5);
    }


}