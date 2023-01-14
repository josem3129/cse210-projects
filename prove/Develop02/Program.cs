using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
            // here is were we call all the classes and varible for the loop 
        string UserInput = "";
        JurnalWrite juranl1 = new JurnalWrite();
        Display display1 = new Display();
        UserQuestion question = new UserQuestion();
        

        question._questionList.Add("Who was the most interesting person I interacted with today?");
        question._questionList.Add("What was the best part of my day?");
        question._questionList.Add("How did I see the hand of the Lord in my life today?");
        question._questionList.Add("What was the strongest emotion I felt today?");
        question._questionList.Add("If I had one thing I could do over today, what would it be?");
        do
        {   
            // do while loop so program continues runing untill user chooses #5
            // menu for the user to choose from and reads answer and saves it in a variable
            Console.WriteLine("Please select one of the foloowing choises");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Add Prompt");
            Console.WriteLine("3. Display");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do?: ");
            UserInput = Console.ReadLine();
            Console.WriteLine("_______________________________");
            
            // if user chooses #1 it will promp randome question and store user answer
            if (UserInput == "1")
            {
                string QuestionToUser = question.DisplayQuestion();
                juranl1._questionUse = QuestionToUser;
                Console.WriteLine(QuestionToUser);
                Console.Write("> ");
                juranl1._userAnswer = Console.ReadLine();
                string JournalPrint = juranl1.displayJurnal();
                display1._journalEntry.Add(JournalPrint);
                Console.WriteLine("_______________________________");


            }
            // here we exceed core requirements by allowing the user add extra questions to the program
            else if (UserInput == "2")
            {
                Console.WriteLine("Please enter question you would like too add to your jurnal?");
                Console.Write(">");
                question._questionPrompt = Console.ReadLine();
                question.addingPrompt();
                Console.WriteLine("Question added..\n");
            }

            // choise #2 were it prints the journal entries
            else if (UserInput == "3")
            {
                display1.DisplayChoise();
            }

            // choise #3 were Loads file 
            else if (UserInput == "4")
            {
                string filename = "journal.txt";
                string[] lines = System.IO.File.ReadAllLines(filename);
                

                foreach (string line in lines)
                {
                    display1._journalEntry.Add(line);
                }

                Console.WriteLine("File Loaded..\n");

            }

            // Choise 4 print journal entry in to a file
            else if (UserInput == "5")
            {
               WriteAllLines print = new WriteAllLines();

               print._linesRead = display1._journalEntry;
               print.PrintLines();
               Console.WriteLine("saved..\n");
            }

            
        }while (UserInput != "6");

        // Goofbye message for user to let them know program is done. 

        Console.WriteLine("_______________________________");
        Console.Write("Goodbye!");
        
    }
}