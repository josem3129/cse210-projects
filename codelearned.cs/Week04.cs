        // sleep code and syntax
        Console.WriteLine("Going to sleep for a second...");

        Thread.Sleep(1000);

        Console.WriteLine("I'm back!!");   

         //Display Animations

        Console.Write("\\");
        do
        {

        Thread.Sleep(500);

        Console.Write("\b \b"); // Erase the + character
        Console.Write("/"); // Replace it with the - character
        Thread.Sleep(100);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("_");
        Thread.Sleep(100);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("\\");
        Thread.Sleep(100);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("|");
        } while (1==1);

        // adding seconds date time 
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5000);

        Thread.Sleep(3000);

        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
            Console.WriteLine("We have not arrived at our future time yet...");

        }

         DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_waitDuration);
        DateTime currentTime;
        Console.Write("|");

        //date time with loops
        do
        {
            
            Console.Write("\b \b"); // Erase the + character
            Console.Write("/"); // Replace it with the - character
            Thread.Sleep(550);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("_");
            Thread.Sleep(550);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("\\");
            Thread.Sleep(550);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("|");
            
           
            currentTime =  DateTime.Now;
            

        }while(currentTime < futureTime);
        Console.Write("\b \b");