public class _writeAllLines
{
    public List<string> Lines = new List<string>();

    public void PrintLines ()
    {
        DateTime TimeStamp = DateTime.Now;
        string dateText = TimeStamp.ToShortDateString();

       string fileName = "journal.txt";
       
       _display filedisplay = new _display();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            
            foreach (string file in Lines)
            {
                outputFile.WriteLine(file);
                

            }
            
        
        }
    }
}