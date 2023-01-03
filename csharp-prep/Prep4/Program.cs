using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> NumList = new List<int>();
        int number = -1;


        while (number != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished. ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0)
            {
                NumList.Add(number);
            }
        }

        int adding = 0;

        foreach (int num in NumList)
        {
           adding += num;

        }

        Console.WriteLine($"The sum is: {adding}");

        float average =  ((float)adding) / NumList.Count;
        Console.WriteLine($"The average is: {average}");

        int Largestnum = 0;

        foreach (int num in NumList)
        {
            if (num > Largestnum)
            {
                Largestnum = num;
            }
        }

        Console.WriteLine($"The largest number is: {Largestnum}");

    }
}