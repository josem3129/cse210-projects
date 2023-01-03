using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your score in your test? ");
        string ScoreGrade = Console.ReadLine();

        int x = int.Parse(ScoreGrade);

        if (x >= 90)
        {
            Console.WriteLine($"You got an A on your test");
        }
        else if (x <= 89 &&  x >= 80 )
        {
            Console.WriteLine($"You got an B on your test");
        }
        else if (x <= 79 &&  x >=70 )
        {
            Console.WriteLine($"You got an C on your test");
        }
        else if (x <= 69 ||  x >= 60 )
        {
            Console.WriteLine($"You got an D on your test");
        }
        else
        {
            Console.WriteLine($"You got an F on your test");
        }
    }
}