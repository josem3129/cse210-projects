using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!");
        // Console.Write("how old are you? ");
        // string age = Console.ReadLine();

        // Console.WriteLine($"Your age is {age}"); 

        Console.WriteLine("Enter a date: ");
        DateTime userDateTime;
        if (DateTime.TryParse(Console.ReadLine(), out userDateTime))
        {
            Console.WriteLine("The day of the week is: " + userDateTime.DayOfWeek);
        }
        else
        {
            Console.WriteLine("You have entered an incorrect value.");
        }
        Console.ReadLine();
        

    }
}