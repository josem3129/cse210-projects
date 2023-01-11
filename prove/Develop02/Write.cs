public class JurnalWrite
{
    
    //
    public string _UserAnswer;
    public string _QuestionUse;

    public string DisplayJurnal ()
    {
        DateTime TimeStamp = DateTime.Now;
        string dateText = TimeStamp.ToShortDateString();

        
        string display = ($"Date: {dateText} - Prompt: {_QuestionUse} {_UserAnswer}.");
        return display;

    }
}
