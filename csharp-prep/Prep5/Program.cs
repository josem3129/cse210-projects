using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string UserName = PromptUserName();
        int FavoriteNumber = PromptUserNumber();

        

        DisplayResult(UserName, SquareNumber(FavoriteNumber));
        
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int ParsNum = int.Parse(number);
        return ParsNum;
    }

    static int SquareNumber(int FavoriteNumber)
    {
        int sqr = FavoriteNumber * FavoriteNumber;
        return sqr;
    }

    static void DisplayResult(string userName, int FavoriteNumber )
    {
        Console.WriteLine($"{userName}, the square of your number is {FavoriteNumber}");
    }
}