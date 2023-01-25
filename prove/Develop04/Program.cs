using System;

class Program
{
    static void Main(string[] args)
    {
       // switch statement that handels user choises 
       // each choise has an activity
        string choise = "";
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start refection activity");
            Console.WriteLine(" 3. Start Listing activty");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menue: ");
            choise = Console.ReadLine();
            
            switch(choise) 
            {
            case "1":
                breathingActivity activit1 = new breathingActivity();
                activit1.SetBegeningPrompt("Breathing activity");
                activit1.BreathingExercise();
                
                break;
            case "2":
                reflectionActivity activity3 = new reflectionActivity();
                activity3.SetBegeningPrompt("Reflection activity");
                activity3.refectionExercise();
                
                break;
            case "3":
                listingActivity activity2 = new listingActivity();
                activity2.SetBegeningPrompt("Lisitng activity");
                activity2.ListingExercise();
                
                break;
            default:
                break;
            }

        }while (choise != "4");


    }
}