public class ScriptureReference
{
        // here i am looking dor the refrence of the scripture, looking for the book, chapter, and verses dpending how many there are 
    private string _book;
    private string _chapter;
    private string _verseNumber;

    private string _secondEndVerseNumber;

    // here we are getting for all the parst of the refence and settig them. 

    public ScriptureReference(string book, string chapter, string verseNumber)
    {
        _book = book;
        _chapter = chapter;
        _verseNumber = verseNumber;
        _secondEndVerseNumber = "";
    
    }

    public ScriptureReference(string book, string chapter, string verseNumber, string secondEndVerseNumber)
    {
        _book = book;
        _chapter = chapter;
        _verseNumber = verseNumber;
        _secondEndVerseNumber = "-" + secondEndVerseNumber;
    }

    // here i am retuening the refrence in to a formated string to be used later in another class. 

    public string DisplayReferance()
    {
        string display = $"{_book} {_chapter} : {_verseNumber}{_secondEndVerseNumber} ";

        return display;
    }
}