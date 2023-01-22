public class Verses
{
    private string _versWord;

    // this gets the verse than sets the verse 


    public Verses(string word)
    {
            _versWord = word;

    }
    public void showWord()
    {
        Console.WriteLine(_versWord);
    }

    // here the class assigns the variable to be show or hide 
    // then returns the asigned word 

    public string HideWord()
    {
        string word= "";
        Random RandomNum = new Random();
        
        
        List<string> hideOrShow = new List<string>();
        hideOrShow.Add("show");
        hideOrShow.Add("hide");


       
        
        int index = RandomNum.Next(hideOrShow.Count);
        string randomeValue = hideOrShow[index];

       
        word = randomeValue;
        

        
        return word;

    }
}