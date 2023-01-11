public class Display 
{
    public List<string> _JuranlEntry = new List<string>();  

    public void DisplayChoise()
    {
        
        
        foreach (string journal in _JuranlEntry)
        {   
            string[] parts = journal.Split("?");

            string Prompt = parts[0];
            string Answer = parts[1];
            Console.WriteLine($"{Prompt}?");
            Console.WriteLine($"{Answer}\n");
        }
    }
}