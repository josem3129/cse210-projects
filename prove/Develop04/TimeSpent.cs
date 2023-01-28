//this class is used to keep track of how long the user is being mindful
// here grabs the activity duration so main program can add it in a list
//then we grab the sum of the list and display it to user formated.
// this is my stretch chalange. 
public class UserTimeSpent : activityDescription
{
    private int _activityCount;

    public int GetactivityCount()
    {
        return _activityCount;
    }

    public void SetactivityCount(int activityCount)
    {
        _activityCount = activityCount;

    }

    public void DurationCalculator ()
    {

        WaitingTIme(3);

        Console.WriteLine($"\nThe total amount spen: {_activityCount} ");
        Console.WriteLine("Congrats!! on trying to be more mindful in you life!! ");
        WaitingTIme(8);

       

    }

    
}