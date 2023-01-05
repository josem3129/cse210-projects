public class Resume
{
    public string _PersonName;
    public List<Job> _ListJobs = new List<Job>();

    public void DisplayResume ()
    {
        Console.WriteLine($"Name: {_PersonName}");
        Console.WriteLine($"Jobs:");
        foreach (Job job in _ListJobs)
        {
            job.displayJobDetails();
        }

    }





}