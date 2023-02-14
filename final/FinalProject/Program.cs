using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> primaryClasses = new List<string>();
        string[] students = {};
        string choise = "";
        Console.Clear();
        Console.WriteLine("Welcome to the Primary program 3000");
        Console.WriteLine("This program pupose is to help primary precidencies to keep track of their");
        Console.WriteLine("primary classes and each student progress.");
        Console.WriteLine("please choose from the following.");
    
        do 
        {
            // using a try catch to find if user enter a valid choise 
            try{

                // main menue class
                // diplaying the choises that user has and reading the answer 
                // initiated each class 
                Menu menu = new Menu();
                Nursery nursery = new Nursery();
                Sunbeams sunbeam = new Sunbeams();
                CTR45 ctr1 = new CTR45();
                CTR67 ctr2 = new CTR67();
                Valiants89 valiant1 = new Valiants89();
                Valiant1011 valiant2 = new Valiant1011();
                menu.DisplayMainMenu();
                Console.Write("Choose from the menu: ");
                choise = Console.ReadLine();
                switch(choise)
                {
                    //case 1 is class entries were use adds student and teacher to a class
                    //display the menue for the classes and choose what class they want to work with when they are done press 7
                    case "1":
                        string classChosen = "";
                        do
                        {
                            
                            menu.DisplayClassMenu();                        
                            classChosen = Console.ReadLine();

                            switch(classChosen)
                            {
                                case "1":
                                    nursery.SetStudentInfo(primaryClasses);
                                    nursery.SetClassName("Nursery");
                                    nursery.ToString();
                                    Console.Clear();
                                break;
                                case "2":
                                    sunbeam.SetStudentInfo(primaryClasses);
                                    sunbeam.SetClassName("Sunbeams");
                                    sunbeam.ToString();
                                break;
                                case "3":
                                    ctr1.SetStudentInfo(primaryClasses);
                                    ctr1.SetClassName("CTR4-5");
                                    ctr1.ToString();
                                break;
                                case "4":
                                    ctr2.SetStudentInfo(primaryClasses);
                                    ctr2.SetClassName("CTR6-7");
                                    ctr2.ToString();
                                break;
                                case "5":
                                    valiant1.SetStudentInfo(primaryClasses);
                                    valiant1.SetClassName("Valiant8-9");
                                    valiant1.ToString();
                                break;
                                case "6":
                                    valiant2.SetStudentInfo(primaryClasses);
                                    valiant2.SetClassName("Valiant10-11");
                                    valiant2.ToString();
                                break;
                                default:
                                break;
                            }
                        } while(classChosen != "7");
                    
                    break;

                    // show students in class with age and their progress
                    case "2":

                        Console.WriteLine();
                        foreach (string classTeacher in primaryClasses)
                        {
                            string[] classSplited = classTeacher.Split(":");

                            if (classSplited[0] == "Nursery")
                            {
                                nursery.SetClassINformation(classTeacher);
                                nursery.DisplayClass();
                            }
                            else if (classSplited[0] == "Sunbeams")
                            {
                                sunbeam.SetClassINformation(classTeacher);
                                sunbeam.DisplayClass();
                            }
                            else if (classSplited[0] == "CTR4-5")
                            {
                                ctr1.SetClassINformation(classTeacher);
                                ctr1.DisplayClass();
                            }
                            else if (classSplited[0] == "CTR6-7")
                            {
                                ctr2.SetClassINformation(classTeacher);
                                ctr2.DisplayClass();
                            }
                            else if (classSplited[0] == "Valinats8-9")
                            {
                                valiant1.SetClassINformation(classTeacher);
                                valiant1.DisplayClass();
                            }
                            else if (classSplited[0] == "Valiants10-11")
                            {
                                valiant2.SetClassINformation(classTeacher);
                                valiant2.DisplayClass();
                            }
                        }
                    break;

                    // #3 allows to add progress to a student in any class. 
                    case "3":

                        Console.WriteLine("Which class would you like to add progess?");
                        menu.DisplayClassMenu();
                        string progressChosen = Console.ReadLine();
                        
                        

                        switch(progressChosen)
                        {
                            case "1":
                                foreach (string classTeacher in primaryClasses.ToList())
                                {
                                    string[] classSplited = classTeacher.Split(":");

                                    if (classSplited[0] == "Nursery")
                                    {
                                        nursery.SetStudentInfo(primaryClasses);
                                        nursery.SetClassINformation(classTeacher);
                                        nursery.Progress();
                                                                    
                                    }
                                }
                            break;
                            case "2":
                                foreach (string classTeacher in primaryClasses)
                                {
                                    string[] classSplited = classTeacher.Split(":");
                                    if (classSplited[0] == "Sunbeams")
                                        {
                                            sunbeam.SetStudentInfo(primaryClasses);
                                            sunbeam.SetClassINformation(classTeacher);
                                            sunbeam.ClassEdit();
                                        }

                                }
                            break;
                            case "3":
                                foreach (string classTeacher in primaryClasses)
                                {
                                    string[] classSplited = classTeacher.Split(":");
                                    if (classSplited[0] == "CTR4-5")
                                        {
                                            ctr1.SetStudentInfo(primaryClasses);
                                            ctr1.SetClassINformation(classTeacher);
                                            ctr1.ClassEdit();
                                        }

                                }
                            break;
                            case "4":
                                foreach (string classTeacher in primaryClasses)
                                {
                                    string[] classSplited = classTeacher.Split(":");
                                    if (classSplited[0] == "CTR6-7")
                                        {
                                            ctr2.SetStudentInfo(primaryClasses);
                                            ctr2.SetClassINformation(classTeacher);
                                            ctr2.ClassEdit();
                                        }

                                }
                            break;
                            case "5":
                                foreach (string classTeacher in primaryClasses)
                                {
                                    string[] classSplited = classTeacher.Split(":");
                                    if (classSplited[0] == "Valinats8-9")
                                        {
                                            valiant1.SetStudentInfo(primaryClasses);
                                            valiant1.SetClassINformation(classTeacher);
                                            valiant1.ClassEdit();
                                        }

                                }
                            break;
                            case "6":
                                foreach (string classTeacher in primaryClasses)
                                {
                                    string[] classSplited = classTeacher.Split(":");
                                    if (classSplited[0] == "Valiants10-11")
                                        {
                                            valiant2.SetStudentInfo(primaryClasses);
                                            valiant2.SetClassINformation(classTeacher);
                                            valiant2.ClassEdit();
                                        }

                                }
                            break;
                        }
                        break;
                    // we save the data here in a file
                    case "4":

                    // here we are saving the goal in to a file which the user geives name. 
                        Console.WriteLine("what is the filename for the file? ");
                        string fileName = Console.ReadLine();
            
                        

                        using (StreamWriter outputFile = new StreamWriter(fileName))
                        {
                            
                            foreach (string file in primaryClasses)
                            {
                                outputFile.WriteLine(file);
                            }    

                        }
                        Console.Write("Saving..");  
                        menu.WaitingTIme(3);
                        Console.WriteLine("\nFile Saved..\n");       
                    
                    break;
                    // here we load the file to be added in to list 
                    case "5":

                        Console.Write("what is the filename for rhe goal file? ");
                        string filename = Console.ReadLine();
                        string[] lines = System.IO.File.ReadAllLines(filename);
                        
                        

                        for (int i = 0; i < lines.Count();  i++)
                        {
                            string goal = lines[i];
                            primaryClasses.Add(goal);
                        }

                        Console.Write("Loading..");  
                        menu.WaitingTIme(3);
                        Console.WriteLine("\nFile loaded..\n");  

                    break;

                    case "6":
                        // #6 allows to edit any class by ther add or remove from an existing class. 
                        Console.Write("Which class would you like to edit?");
                        menu.DisplayClassMenu();
                        string editchosen = Console.ReadLine();
                        
                        
                        // here we are looking for the class that user chose
                        switch(editchosen)
                        {
                            case "1":
                                foreach (string classTeacher in primaryClasses.ToList())
                                {
                                    string[] classSplited = classTeacher.Split(":");

                                    if (classSplited[0] == "Nursery")
                                    {
                                        nursery.SetStudentInfo(primaryClasses);
                                        nursery.SetClassINformation(classTeacher);
                                        nursery.ClassEdit();
                                                                    
                                    }
                                }
                            break;
                            case "2":
                                foreach (string classTeacher in primaryClasses)
                                {
                                    string[] classSplited = classTeacher.Split(":");
                                    if (classSplited[0] == "Sunbeams")
                                        {
                                            sunbeam.SetStudentInfo(primaryClasses);
                                            sunbeam.SetClassINformation(classTeacher);
                                            sunbeam.ClassEdit();
                                        }

                                }
                            break;
                            case "3":
                                foreach (string classTeacher in primaryClasses)
                                {
                                    string[] classSplited = classTeacher.Split(":");
                                    if (classSplited[0] == "CTR4-5")
                                        {
                                            ctr1.SetStudentInfo(primaryClasses);
                                            ctr1.SetClassINformation(classTeacher);
                                            ctr1.ClassEdit();
                                        }

                                }
                            break;
                            case "4":
                                foreach (string classTeacher in primaryClasses)
                                {
                                    string[] classSplited = classTeacher.Split(":");
                                    if (classSplited[0] == "CTR6-7")
                                        {
                                            ctr2.SetStudentInfo(primaryClasses);
                                            ctr2.SetClassINformation(classTeacher);
                                            ctr2.ClassEdit();
                                        }

                                }
                            break;
                            case "5":
                                foreach (string classTeacher in primaryClasses)
                                {
                                    string[] classSplited = classTeacher.Split(":");
                                    if (classSplited[0] == "Valinats8-9")
                                        {
                                            valiant1.SetStudentInfo(primaryClasses);
                                            valiant1.SetClassINformation(classTeacher);
                                            valiant1.ClassEdit();
                                        }

                                }
                            break;
                            case "6":
                                foreach (string classTeacher in primaryClasses)
                                {
                                    string[] classSplited = classTeacher.Split(":");
                                    if (classSplited[0] == "Valiants10-11")
                                        {
                                            valiant2.SetStudentInfo(primaryClasses);
                                            valiant2.SetClassINformation(classTeacher);
                                            valiant2.ClassEdit();
                                        }

                                }
                            break;
                            default:
                            break;
                        }                       
                                              

                    break;
                    
                    default:
                    break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error -- please choose from menu");
            }

        }while (choise != "7");
    }
}