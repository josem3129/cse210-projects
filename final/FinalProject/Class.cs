public abstract class ClassDescription 
{
    protected string _teacherName, _studentName, _birthdate, _className, _classInformation;

   

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
    public int AgeCal()
    {
        //current year.
        DateTime startTime = DateTime.Now;
        int nowYear = startTime.Year;

        // Student Year 
        string[] birth = _birthdate.Split("/");
        
        return nowYear - int.Parse(birth[2]);
    }

    public void DisplayClass()
    {
        string[] classSplited = _classInformation.Split(":");
        string classinfo = classSplited[1];
        string[] classParts = classinfo.Split(",");

        Console.Write($"{classSplited[0]} - {_teacherName = classParts[0]}: ");



        for (int i = 1; i < classParts.Count(); i++)
        {
            _studentsList.Add(classParts[i]);
        }

        foreach(string student in _studentsList)
        {
            string[] studentSplited = student.Split("-");
            SetBirthdate(studentSplited[1]);
            Console.Write($"{studentSplited[0]} age {AgeCal()}, ");
        }
        
    }

    public void ToString()
    {
        
      if (_teacherName == null)
        {          
            SetClassName(GetClassName());
            Console.Write("Please enter teach name: ");
            SetTeacherName(Console.ReadLine());
            Console.Write("Enter student name: ");
            SetStudentName(Console.ReadLine());
            Console.Write("Enter student Birthdate in this format(MM/DD/YYYY)");
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
                        Console.Write("Enter student Birthdate in this format(MM/DD/YYYY)");
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

    public void FindClass()
    {
        string[] classSplited = _classInformation.Split(":");
        string classinfo = classSplited[1];
        string[] classParts = classinfo.Split(",");

        _teacherName = classParts[0];



        for (int i = 1; i < classParts.Count(); i++)
        {
            _studentsList.Add(classParts[i]);
        }
    }

    public void ClassEdit()
    {
        

        Console.WriteLine("Which class would you like to edit?");
        Menu menu = new Menu();
        menu.DisplayClassMenu();
        string classChosen = Console.ReadLine();
        switch(classChosen)
        {
            case "1":
                foreach (string classTeacher in _studentInfo)
                {
                    string[] classSplited = classTeacher.Split(":");
                     if (classSplited[0] == "Nursery")
                        {
                            FindClass();
                        }

                }
        
            break;
            case "2":
                 foreach (string classTeacher in _studentInfo)
                {
                    string[] classSplited = classTeacher.Split(":");
                     if (classSplited[0] == "Sunbeams")
                        {
                            FindClass();
                        }

                }
            break;
            case "3":
                 foreach (string classTeacher in _studentInfo)
                {
                    string[] classSplited = classTeacher.Split(":");
                     if (classSplited[0] == "CTR4-5")
                        {
                            FindClass();
                        }

                }
            break;
            case "4":
                 foreach (string classTeacher in _studentInfo)
                {
                    string[] classSplited = classTeacher.Split(":");
                     if (classSplited[0] == "CTR6-7")
                        {
                            FindClass();
                        }

                }
            break;
            case "5":
                 foreach (string classTeacher in _studentInfo)
                {
                    string[] classSplited = classTeacher.Split(":");
                     if (classSplited[0] == "Valinats8-9")
                        {
                            FindClass();
                        }

                }
            break;
            case "6":
                 foreach (string classTeacher in _studentInfo)
                {
                    string[] classSplited = classTeacher.Split(":");
                     if (classSplited[0] == "Valiants10-11")
                        {
                            FindClass();
                        }

                }
            break;
            default:
            break;
        }    
        

    }

    
}
