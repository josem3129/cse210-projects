public class JurnalWrite
{
    
    //
    public string _userAnswer;
    public string _questionUse;

    public string displayJurnal ()
    {
        DateTime TimeStamp = DateTime.Now;
        string dateText = TimeStamp.ToShortDateString();

        
        string display = ($"Date: {dateText} - Prompt: {_questionUse} {_userAnswer}.");
        return display;

    }
}
