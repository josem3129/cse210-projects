public class Scripture 
{
    // here we are looking for the scripture refreance and the verse of the scripture 
    private string _scriptureReference;
    private string _word;

    // list that save the words 

    private List<string> _scriptureWords = new List<string>();

    private List<string> _wordsHide = new List<string>();

    // here we are getting both word and referance and set it 
    public Scripture(string scripture, string word)
    {
        _word = word;
        _scriptureReference = scripture;

    }

    // here we are adding each word from the verese and saving it to the list called scriptures
    public void AddWord()
    {
        string[] scriptureVerse = _word.Split(" ");
        foreach (string word in scriptureVerse)
        {
            _scriptureWords.Add(word);
        }
    }

    // here we are grving each word from the list and calling the class hide word that assigns ether show are hide word 
    // if the word is show it will show and if it says hide it will save it in a list and hide that word with dashes 
    // than both list are compared and of the word is found in the list it does not hide again with dashes. 
    public void Printword()
    {

        string userInput = "";

        do
        {

            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();
            Console.Clear();
            Console.Write(_scriptureReference);

            foreach (string word in _scriptureWords)
            {
                
                Verses verse1 = new Verses(word);
                string randomValue = verse1.HideWord();
            
                // Console.Write($" {word1}");

                if (randomValue == "show" )
                {
                    if (_wordsHide.Contains(word))
                    {
                        Console.Write(" ");
                        for (int i = 0; i < word.Count(); i ++)
                        {
                            
                            Console.Write("_");

                        }
                    }

                    else
                    {

                        Console.Write($" {word}");
                    }

                }

                else if (randomValue == "hide")
                {
                    if (_wordsHide.Contains(word))
                    {
                        Console.Write(" ");
                        for (int i = 0; i < word.Count(); i ++)
                        {
                            
                            Console.Write("_");

                        }
                    }

                    else
                    {

                        _wordsHide.Add(word);
                        Console.Write(" ");
                        for (int i = 0; i < word.Count(); i ++)
                        {
                        
                            Console.Write("_");

                        }
                    }

                }
            }
            
        } while (userInput != "quit");
                
                
    
        
    }

}