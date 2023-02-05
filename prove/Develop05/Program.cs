using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal simpleGoal = new SimpleGoal();
        EternalGoal eternalGoal = new EternalGoal();
        ChecklistGoal checklistGoal = new ChecklistGoal();
        List<string> goalList = new List<string>();
        List<string> completedGoal = new List<string>();
    
        string choise = "";
        int totalPoints = 0;
        do
        {
        
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Create New Goal");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record event");
        Console.WriteLine(" 6. Quit");
        Console.Write("Select a choice from the menu: ");
        choise = Console.ReadLine();
         switch(choise) 
            {
            case "1":
                
                Console.WriteLine("");
                Console.WriteLine("The type of Goals are:");
                Console.WriteLine(" 1. Simple Goal");
                Console.WriteLine(" 2. Eternal Goals");
                Console.WriteLine(" 3. Checklist Goals");
                Console.Write("Select a choice from the menu: ");
                string goalChoise = Console.ReadLine();
                    switch(goalChoise) 
                {
                case "1":
                    simpleGoal.SetTypeOfGoal("Simple Goal");
                    Console.WriteLine("What is the name of your goal?");
                    string nameAnswer = Console.ReadLine();
                    simpleGoal.SetGoalName(nameAnswer);
                    Console.WriteLine("What is a short description of it?");
                    string descriptionAnswer = Console.ReadLine();
                    simpleGoal.SetGoalInfo(descriptionAnswer);
                    Console.WriteLine("What is the amount of points associated with this goal?");
                    string pointsAnswer = Console.ReadLine();
                    simpleGoal.SetScoreGoal(pointsAnswer);
                    simpleGoal.SetGoaldone(false);
                    goalList.Add(simpleGoal.SaveToFile());
                    
                                    
                    break;
                case "2":

                    eternalGoal.SetTypeOfGoal("Eternal Goal");
                    Console.WriteLine("What is the name of your goal?");
                    string nameAnswer2 = Console.ReadLine();
                    eternalGoal.SetGoalName(nameAnswer2);
                    Console.WriteLine("What is a short description of it?");
                    string descriptionAnswer2 = Console.ReadLine();
                    eternalGoal.SetGoalInfo(descriptionAnswer2);
                    Console.WriteLine("What is the amount of points associated with this goal?");
                    string pointsAnswer2 = Console.ReadLine();
                    eternalGoal.SetScoreGoal(pointsAnswer2);
                    
                    goalList.Add(eternalGoal.SaveToFile());
                    
                    break;
                case "3":
                    checklistGoal.SetTypeOfGoal("Checklist Goal");
                    Console.WriteLine("What is the name of your goal?");
                    string nameAnswer3 = Console.ReadLine();
                    checklistGoal.SetGoalName(nameAnswer3);
                    Console.WriteLine("What is a short description of it?");
                    string descriptionAnswer3 = Console.ReadLine();
                    checklistGoal.SetGoalInfo(descriptionAnswer3);
                    Console.WriteLine("What is the amount of points associated with this goal?");
                    string pointsAnswer3 = Console.ReadLine();
                    checklistGoal.SetScoreGoal(pointsAnswer3);
                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
                    string amountOfTImes = Console.ReadLine();
                    checklistGoal.SetAmountOftimes(amountOfTImes);
                    Console.Write("What is the bonuis for accomplishing it that many times?");
                    string bonus = Console.ReadLine();
                    checklistGoal.SetBonusPoints(bonus);
                    checklistGoal.SetGoalsRecordedList(completedGoal);
                    
                    goalList.Add(checklistGoal.SaveToFile());
                    

                    break;
                default:
                    break;
                }
                                                
                break;
            case "2":

                Console.WriteLine($"Total Points: {totalPoints}");
                
                
                foreach (string element in goalList)
                {   
                    SimpleGoal simpleGoal2 = new SimpleGoal();
                    EternalGoal eternalGoal2 = new EternalGoal();
                    ChecklistGoal checklistGoal2 = new ChecklistGoal();
                    
                    var item = element.Split(":");
                    var goal = item[1].Split(",");

                    string goalNames = goal[0];
                    string goalDescription = goal[1];

                    if (item[0] == "Simple Goal")
                    {
                        if (goal[3] == "False")
                        {
                            
                            simpleGoal2.SetGoalName(goalNames);
                            simpleGoal2.SetGoalInfo(goalDescription);
                            simpleGoal2.DisplayGoal();
                        }
                        else if (goal[3] == "True")
                        {
                            
                            simpleGoal2.SetGoalName(goalNames);
                            simpleGoal2.SetGoalInfo(goalDescription);
                            simpleGoal2.DisplayDone();
                        }
                                            
                    }
                    else if (item[0] == "Eternal Goal")
                    {
                        
                        eternalGoal2.SetGoalName(goalNames);
                        eternalGoal2.SetGoalInfo(goalDescription);
                        eternalGoal2.DisplayGoal();

                    }
                    else if (item[0] == "Checklist Goal")
                    {
                        checklistGoal2.SetBonusPoints(goal[3]);
                        checklistGoal2.SetAmountOftimesDone(goal[5]);
                        checklistGoal2.SetAmountOftimes(goal[4]);
                        checklistGoal2.SetGoalName(goalNames);
                        checklistGoal2.SetGoalInfo(goalDescription);
                        checklistGoal2.DisplayGoal();                  
                    }
                   
                }

                
                break;
            case "3":
                
                string fileName = "Goals.txt";
       
                

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine(totalPoints);
                    foreach (string file in goalList)
                    {
                        outputFile.WriteLine(file);
                        

                    }
                Console.WriteLine("File Saved..\n");       
                        
                    
        }
               break;
            case "4":
                string filename = "Goals.txt";
                string[] lines = System.IO.File.ReadAllLines(filename);
                
                totalPoints = int.Parse(lines[0]);

                for (int i = 1; i < lines.Count();  i++)
                {
                    string goal = lines[i];
                   goalList.Add(goal);
                }

                Console.WriteLine("File Loaded..\n");
                break;
            case "5":

                Console.WriteLine(totalPoints);
                int count = 0;
                foreach (string element in goalList)
                {   
                    var item = element.Split(":");
                    var item2 = item[1].Split(",");

                    string goalName = item2[0];
                    count ++;
                    Console.WriteLine($" {count}. {goalName}");
                }

                Console.Write("Which goal did you accomplish?");
                string answerGoal = Console.ReadLine();
                var goalSelected = goalList[int.Parse(answerGoal) - 1];
                var itemSplited = goalSelected.Split(":");
                var goalInfo = itemSplited[1].Split(",");

                if (itemSplited[0] == "Simple Goal" && goalInfo[3] == "False")
                {
                    
                    simpleGoal.SetGoalName(goalInfo[0]);
                    simpleGoal.SetGoalInfo(goalInfo[1]);
                    simpleGoal.SetGoalMadeList(goalList);
                    simpleGoal.SetIndex(int.Parse(answerGoal) - 1);
                    simpleGoal.SetPointsEarned(int.Parse(goalInfo[2]));
                    simpleGoal.SetTotalGoal(totalPoints);
                    totalPoints = int.Parse(simpleGoal.RecordEvent());
                    
                }
                else if (itemSplited[0] == "Eternal Goal")
                {
                    eternalGoal.SetGoalMadeList(goalList);
                    eternalGoal.SetIndex(int.Parse(answerGoal) - 1);
                    eternalGoal.SetGoalName(goalInfo[0]);
                    eternalGoal.SetGoalInfo(goalInfo[1]);
                    eternalGoal.SetPointsEarned(int.Parse(goalInfo[2]));
                    eternalGoal.SetTotalGoal(totalPoints);
                    totalPoints = int.Parse(eternalGoal.RecordEvent());
                }
                else if (itemSplited[0] == "Checklist Goal")
                {
                    int addedRecord = int.Parse(goalInfo[5]) + 1;
                    checklistGoal.SetIndex(int.Parse(answerGoal) - 1);
                    checklistGoal.SetGoalMadeList(goalList);
                    checklistGoal.SetGoalInfo(goalInfo[1]);
                    checklistGoal.SetScoreGoal(goalInfo[2]);
                    checklistGoal.SetBonusPoints(goalInfo[3]);
                    checklistGoal.SetAmountOftimes(goalInfo[4].ToString());
                    checklistGoal.SetAmountOftimesDone(addedRecord.ToString());
                    checklistGoal.SetPointsEarned(int.Parse(goalInfo[2]));
                    checklistGoal.SetTotalGoal(totalPoints);
                    checklistGoal.SetBonusPoints(goalInfo[3]);
                    checklistGoal.SetGoalName(goalInfo[0]);
                    totalPoints = int.Parse(checklistGoal.RecordEvent());                    
                }
                break;
            default:
                break;
            }
        }while (choise != "6");    
        
        
        // Console.WriteLine(GetUserGoal(goal));
        
    }

    public static string GetUserGoal(GoalsDescription goalDescription)
    {
        return $"[] {goalDescription.GetTypeOfGoal()}: {goalDescription.GetGoalName()},{goalDescription.GetGoalInfo()},{goalDescription.GetScoreGoal()}";
    }
}