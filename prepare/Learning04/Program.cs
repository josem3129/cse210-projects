using System;

class Program
{
    static void Main(string[] args)
    {
        assigment assigment1 = new assigment();
        mathAssignment mathassigment1 = new mathAssignment();
        writingAssigment writingassigment1 = new writingAssigment();

        mathassigment1.SetStudentName("Chloe");
        mathassigment1.SetTopic("Fractions");
        mathassigment1.SetTextBookSection("2.2");
        mathassigment1.SetProblem("1/2");

        Console.WriteLine(mathassigment1.GetHomeworkList());

        writingassigment1.SetStudentName("Spencer");
        writingassigment1.SetTopic("WII casues");
        writingassigment1.SetTitle("Why bear solved WII");

        Console.WriteLine(writingassigment1.GetWritingInformation());



        
        
    }
}