public class Display 
{
    public List<string> _journalEntry = new List<string>();  

    public void DisplayChoise()
    {
        
        
        foreach (string journal in _journalEntry)
        {   
            string[] parts = journal.Split("?");

            string Prompt = parts[0];
            string Answer = parts[1];
            Console.WriteLine($"{Prompt}?");
            Console.WriteLine($"{Answer}\n");
        }
    }
}