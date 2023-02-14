class Menu
{
    private List<string> _mainMenu, _classMenu;

    // here is the menu of the program that is used to direct user what to do
    public Menu()
    {
        _mainMenu = new List<string>
        {
            "\nMenu Options:",
            " 1. Class Entry",
            " 2. Show classes",
            " 3. Progress",
            " 4. Save",
            " 5. Load",
            " 6. Edit clases",
            " 7. Quit"
        };

        _classMenu = new List<string>
        {
            "This are the avilable classes",
            " 1. Nusery",
            " 2. Sunbeams",
            " 3. CTR 4-5",
            " 4. CTR 6-7",
            " 5. Valiant 8-9",
            " 6. Valiant 10-11",
            " 7. Done",
            "choose a class: "
        };
    }

    //this displays the menu for the main prgram 
    public void DisplayMainMenu()
    {
        foreach(string menuItem in _mainMenu)
        {
            Console.WriteLine(menuItem);
        }
    }

//Here we are priting the menu for the primary classes that used in 3 other ares.
    public void DisplayClassMenu()
    {
        foreach(string menuClass in _classMenu)
        {
            if (menuClass == "choose a class: ")
            {
                Console.Write(menuClass);
            }
            else if (menuClass != "choose a class: ")
            {
                Console.WriteLine(menuClass);

            }
             
        }
    }

    // I added this waiting timer too give a loading and saving efect to the user. 
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