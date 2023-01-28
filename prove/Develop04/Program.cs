using System;

class Program
{
    static void Main(string[] args)
    {
       // switch statement that handels user choises 
       // each choise has an activity
        string choise = "";

        List<int> timeSpentList = new List<int>();
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start refection activity");
            Console.WriteLine(" 3. Start Listing activty");
            Console.WriteLine(" 4. How much time spent");
            Console.WriteLine(" 5. Quit");
            Console.Write("Select a choice from the menue: ");
            choise = Console.ReadLine();
            
            switch(choise) 
            {
            case "1":
                breathingActivity activit1 = new breathingActivity("Breathing activity");
                activit1.SetBegeningPrompt("Breathing activity");
                activit1.BreathingExercise();
                timeSpentList.Add(activit1.DurationOfActivity());
                
                break;
            case "2":
                reflectionActivity activity3 = new reflectionActivity();
                activity3.SetBegeningPrompt("Reflection activity");
                activity3.refectionExercise();
                timeSpentList.Add(activity3.DurationOfActivity());
                
                break;
            case "3":
                listingActivity activity2 = new listingActivity();
                activity2.SetBegeningPrompt("Lisitng activity");
                activity2.ListingExercise();
                timeSpentList.Add(activity2.DurationOfActivity());

               break;
            case "4":
                UserTimeSpent timeSpent = new UserTimeSpent();
                int total = timeSpentList.Sum();
                timeSpent.SetactivityCount(total);
                timeSpent.DurationCalculator();
                break;
            default:
                break;
            }

        }while (choise != "5");


    }
}