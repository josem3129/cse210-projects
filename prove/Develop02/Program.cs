using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string UserInput = "";
        JurnalWrite juranl1 = new JurnalWrite();
        Display display1 = new Display();
        UserQuestion question = new UserQuestion();
        do
        {   
            // do while loop so program continues runing untill user chooses #5
            // menu for the user to choose from and reads answer and saves it in a variable
            Console.WriteLine("Please select one of the foloowing choises");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?: ");
            UserInput = Console.ReadLine();
            
            // if user chooses #1 it will promp randome question and store user answer
            if (UserInput == "1")
            {
                string QuestionToUser = question.DisplayQuestion();
                juranl1._QuestionUse = QuestionToUser;
                Console.WriteLine(QuestionToUser);
                Console.Write("> ");
                juranl1._UserAnswer = Console.ReadLine();
                string JournalPrint = juranl1.DisplayJurnal();
                display1._JuranlEntry.Add(JournalPrint);


            }

            // choise #2 were it prints the journal entries
            else if (UserInput == "2")
            {
                display1.DisplayChoise();
            }

            // choise #3 were Loads file 
            else if (UserInput == "3")
            {
                string filename = "journal.txt";
                string[] lines = System.IO.File.ReadAllLines(filename);
                

                foreach (string line in lines)
                {
                    display1._JuranlEntry.Add(line);
                }

            }

            // Choise 4 print journal entry in to a file
            else if (UserInput == "4")
            {
               WriteAllLines print = new WriteAllLines();

               print.Lines = display1._JuranlEntry;
               print.PrintLines();
            }

            //choise 5 stops program. 
            else if (UserInput == "5")
            {
                break;
            }

        }while (UserInput != "5");
        
    }
}