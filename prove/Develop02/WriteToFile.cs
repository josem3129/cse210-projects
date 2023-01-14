public class WriteAllLines
{
    public List<string> _linesRead = new List<string>();

    public void PrintLines ()
    {
        DateTime TimeStamp = DateTime.Now;
        string dateText = TimeStamp.ToShortDateString();

       string fileName = "journal.txt";
       
       Display filedisplay = new Display();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            
            foreach (string file in _linesRead)
            {
                outputFile.WriteLine(file);
                

            }
            
        
        }
    }
}