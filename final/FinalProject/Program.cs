using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> primaryClasses = new List<string>();
        string[] students = {};
        string choise = "";
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
                            Console.Write("Choose a class: ");
                            classChosen = Console.ReadLine();

                            switch(classChosen)
                            {
                                case "1":
                                    nursery.SetStudentInfo(primaryClasses);
                                    nursery.SetClassName("Nursery");
                                    nursery.ToString();
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

                    // show students in class with age
                    case "2":
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

                    case "3":

                    break;
                    // we save the data here in a file
                    case "4":

                    // here we are saving the goal in to a file which the user geives name. 
                        // Console.WriteLine("what is the filename for the file? ");
                        // string fileName = Console.ReadLine();
            
                        

                        using (StreamWriter outputFile = new StreamWriter("primary.txt"))
                        {
                            
                            foreach (string file in primaryClasses)
                            {
                                outputFile.WriteLine(file);
                            }    

                        }
                        menu.WaitingTIme(3);
                        Console.WriteLine("File Saved..\n");       
                    
                    break;
                    // here we load the file to be added in to list 
                    case "5":

                        Console.WriteLine("what is the filename for rhe goal file? ");
                        string filename = Console.ReadLine();
                        string[] lines = System.IO.File.ReadAllLines(filename);
                        
                        

                        for (int i = 0; i < lines.Count();  i++)
                        {
                            string goal = lines[i];
                            primaryClasses.Add(goal);
                        }

                        Console.WriteLine("File Loaded..\n");

                    break;

                    case "6":
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

                    case "7":
                    
                    break;

                    default:
                    break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error -- please choose from menu");
            }

        }while (choise != "8");
    }
}