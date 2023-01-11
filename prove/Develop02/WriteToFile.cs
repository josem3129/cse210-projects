public class WriteAllLines
{
    public List<string> Lines = new List<string>();

    public void PrintLines ()
    {
        DateTime TimeStamp = DateTime.Now;
        string dateText = TimeStamp.ToShortDateString();

       string fileName = "journal.txt";
       
       Display filedisplay = new Display();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            
            foreach (string file in Lines)
            {
                outputFile.WriteLine(file);
                

            }
            
        
        }
    }
}