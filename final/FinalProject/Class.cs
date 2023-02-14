public abstract class ClassDescription 
{
    // here we are decalring, seting and getting the variables that are needed 
    protected string _teacherName, _studentName, _birthdate;

    protected string  _className, _classInformation, _progress;
   

    protected  List<string> _studentInfo = new List<string>();
    protected List<string> _studentsList = new List<string>();

    public string GetClassInformation()
    {
        return _classInformation;
    }
    public void SetClassINformation(string classInformation)
    {
        _classInformation = classInformation;
    }
    public List<string> GetStudentInfo()
    {
        return _studentInfo;
    }

    public void SetStudentInfo(List<string> studentinfo)
    {
        _studentInfo = studentinfo;
    }
    
    public string GetTeacherName()
    {
        return _teacherName;
    }
    public void SetTeacherName(string teacherName)
    {
        _teacherName = teacherName;
    }

    public string GetStudentName()
    {
        return _studentName;
    }
    public void SetStudentName(string studentName)
    {
        _studentName = studentName;
    }

    public string GetBirthdate()
    {
        return _birthdate;
    }
    public void SetBirthdate(string birthdate)
    {
        _birthdate = birthdate;
    }

    public string GetClassName()
    {
        return _className;
    }
    public void SetClassName(string className)
    {
        _className = className;
    }
    public string GetProgress()
    {
        return _progress;
    }
    public void SetProgress(string progress)
    {
        _progress = progress;
    }
    // this method calculate the age of the child by using the date time 
    // and subtracting the current year to the year of the child it was born. 
    public int AgeCal()
    {
        //current year.
        DateTime startTime = DateTime.Now;
        int nowYear = startTime.Year;

        // Student Year 
        string[] birth = _birthdate.Split("/");
        
        return nowYear - int.Parse(birth[2]);
    }
    // this method is used when user want to see what classes are there
    // is shows the class name, teachers name, student name and the age and if there is progress 
    public void DisplayClass()
    {
        string[] classSplited = _classInformation.Split(":");
        string classinfo = classSplited[1];
        string[] classParts = classinfo.Split(",");

        
        Console.Write($"\n{classSplited[0]} - {_teacherName = classParts[0]}: ");



        for (int i = 1; i < classParts.Count(); i++)
        {
            _studentsList.Add(classParts[i]);
        }

        foreach(string student in _studentsList)
        {
            
            string[] studentSplited = student.Split("-");
            if (studentSplited.Count() == 2 )
            {
                SetBirthdate(studentSplited[1]);
                Console.Write($"{studentSplited[0]} age {AgeCal()}");
                Console.Write(", ");

            }
            else if (studentSplited.Count() == 3)
            {
                SetBirthdate(studentSplited[1]);
                Console.Write($"{studentSplited[0]} age {AgeCal()} progress: {studentSplited[2]}%");
                Console.Write(", ");
            }
        }

        Console.Write("\b \b");Console.Write("\b \b");
        
    }
// this programm puts the information the user adds and puts it all togther in a string then saved in a list with all its parts 
    public void ToString()
    {
        
      if (_teacherName == null)
        {          
            SetClassName(GetClassName());
            Console.Write("Please enter teach name: ");
            SetTeacherName(Console.ReadLine());
            Console.Write("Enter student name: ");
            SetStudentName(Console.ReadLine());
            Console.Write("Enter student birthdate in this format (MM/DD/YYYY): ");
            SetBirthdate(Console.ReadLine());
            _studentsList.Add($"{_className}:{_teacherName}");             
            _studentsList.Add($"{_studentName}-{_birthdate}");
            string answer = "";
            do
            {
                Console.WriteLine("Woudl you like to add another name?");
                Console.WriteLine(" 1. Yes.");
                Console.WriteLine(" 2. No.");
                Console.Write("choose from options:");
                answer = Console.ReadLine();
                switch(answer)
                {
                    case "1":
                        Console.Write("Enter student name: ");
                        SetStudentName(Console.ReadLine());
                        Console.Write("Enter student birthdate in this format (MM/DD/YYYY): ");
                        SetBirthdate(Console.ReadLine());          
                        _studentsList.Add($"{_studentName}-{_birthdate}");

                    break;
                    default:
                    break;
                }
            }while(answer != "2");

        }
        else if (_teacherName != null)
        {
            
            Console.Write("Enter student name: ");
            SetStudentName(Console.ReadLine());
            Console.Write("Enter student Birthdate in this format (MM/DD/YYYY)");
            SetBirthdate(Console.ReadLine());          
            _studentsList.Add($"{_studentName}-{_birthdate}");
            string answer = "";
            do
            {
                Console.WriteLine("Woudl you like to add another name?");
                Console.WriteLine(" 1. Yes.");
                Console.WriteLine(" 2. No.");
                Console.Write("choose from options:");
                answer = Console.ReadLine();
                switch(answer)
                {
                    case "1":
                        Console.Write("Enter student name: ");
                        SetStudentName(Console.ReadLine());
                        Console.Write("Enter student Birthdate in this format(MM/DD/YYYY)");
                        SetBirthdate(Console.ReadLine());           
                        _studentsList.Add($"{_studentName}-{_birthdate}");

                    break;
                    default:
                    break;
                }
            }while(answer != "2");
        } 

        _studentInfo.Add(String.Join(",", _studentsList.ToArray()));  
       
    }
// this is a method that use by another methid to split the primary class the is chosen so it can be edit
    public void FindClass()
    {
        string[] classSplited = _classInformation.Split(":");
        string classinfo = classSplited[1];
        string[] classParts = classinfo.Split(",");

        _teacherName = classParts[0];
        _className = classSplited[0];

        


        for (int i = 1; i < classParts.Count(); i++)
        {
            _studentsList.Add(classParts[i]);
        }
    }

    
// this methid edits the data that use input or laoded and allows the user to add or remove students. 
    public void ClassEdit()
    {
        int count = 0;

        FindClass();
        _studentInfo.Remove(_classInformation);      
        Console.WriteLine("Would you like to do?");
        Console.WriteLine(" 1. Add");
        Console.WriteLine(" 2. Remove");
        Console.WriteLine(" 3. Done");
        Console.Write("Chose from one of this options:");
        string choise = Console.ReadLine();

        switch (choise)
        {
            case "1":
                Console.Write("Enter student name: ");
                SetStudentName(Console.ReadLine());
                Console.Write("Enter student birthdate in this format (MM/DD/YYYY): ");
                SetBirthdate(Console.ReadLine());          
                _studentsList.Add($"{_studentName}-{_birthdate}");
                string answer = "";
                do
                {
                    Console.WriteLine("Woudl you like to add another name?");
                    Console.WriteLine(" 1. Yes.");
                    Console.WriteLine(" 2. No.");
                    Console.Write("choose from options:");
                    answer = Console.ReadLine();
                    switch(answer)
                    {
                        case "1":
                            Console.Write("Enter student name: ");
                            SetStudentName(Console.ReadLine());
                            Console.Write("Enter student birthdate in this format (MM/DD/YYYY): ");
                            SetBirthdate(Console.ReadLine());           
                            _studentsList.Add($"{_studentName}-{_birthdate}");

                        break;
                        default:
                        break;
                    }
                }while(answer != "2");
            break;
            case "2":
                foreach (string student in _studentsList)
                {
                    count++;
                    Console.WriteLine($"{count}. {student}");
                }
                Console.Write("Please choose from the fallowing: ");
                string index = Console.ReadLine();
                
                _studentsList.RemoveAt(int.Parse(index)- 1);
            break;
            default:
            break;
        }

        _studentsList.Insert(0, $"{_className}:{_teacherName}");   
        _studentInfo.Add(String.Join(",", _studentsList.ToArray()));  
                   
    }
// here is the abstract method that messures the progrss for each class and adds it to the student 
    public abstract void Progress();
   
    
}
