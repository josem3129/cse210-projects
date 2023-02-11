class Menu
{
    

    private List<string> _mainMenu, _classMenu;

    public Menu()
    {
        _mainMenu = new List<string>
        {
            "\nMenu Options:",
            " 1. Class Entry",
            " 2. Show classes",
            " 3. Attendance",
            " 4. Save",
            " 5. Load",
            " 6. Edit clases",
            " 7. Show Birthdates",
            " 8. Quit"
        };

        _classMenu = new List<string>
        {
            "choose a class:",
            " 1. Nusery",
            " 2. Sunbeams",
            " 3. CTR 4-5",
            " 4. CTR 6-7",
            " 5. Valiant 8-9",
            " 6. Valiant 10-11",
            " 7. Done" 
        };
    }

    public void DisplayMainMenu()
    {
        foreach(string menuItem in _mainMenu)
        {
            Console.WriteLine(menuItem);
        }
    }

    public void DisplayClassMenu()
    {
        foreach(string menuClass in _classMenu)
        {
            Console.WriteLine(menuClass);
        }
    }

    public void WaitingTIme(int _waitDuration)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_waitDuration);
        DateTime currentTime;
        Console.Write("|");

        do
        {
            Thread.Sleep(550);
            Console.Write("\b \b");
            Console.Write("/"); 
            Thread.Sleep(550);
            Console.Write("\b \b"); 
            Console.Write("_");
            Thread.Sleep(550);
            Console.Write("\b \b"); 
            Console.Write("\\");
            Thread.Sleep(550);
            Console.Write("\b \b"); 
            Console.Write("|");
            
           
            currentTime =  DateTime.Now;
            

        }while(currentTime < futureTime);
        Console.Write("\b \b");
    }
}