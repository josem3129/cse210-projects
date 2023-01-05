using System;

class Program
{
    static void Main(string[] args)
    {
        // step 5 
        // job 1
        Resume resume1 = new Resume();        
        Job job1 = new Job();
        resume1._PersonName = "John Cena";
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        //job 2
        Job job2 = new Job();
        job2._jobTitle = "Sofware Manager";
        job2._company = "apple";
        job2._startYear = 2002;
        job2._endYear = 20019;

        //step 8 - Resume
        //adding jobs
        resume1._ListJobs.Add(job1);
        resume1._ListJobs.Add(job2);

        resume1.DisplayResume();
        

        
    
        

    }
}
