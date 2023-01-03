using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string GuessNum = "";
        int intnum = 0;

        GuessNum = Console.ReadLine();
        intnum = int.Parse(GuessNum);

        Random RandomNum = new Random();
        int number = RandomNum.Next(1,11);

        

        do
        {
            if (intnum > number)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess?" );
                intnum = int.Parse(GuessNum);
            }
            else if (intnum < number)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess?" );
                GuessNum = Console.ReadLine();
                intnum = int.Parse(GuessNum);
            }



        } while (intnum != number);

        Console.WriteLine("You guessed it!");
    }
}