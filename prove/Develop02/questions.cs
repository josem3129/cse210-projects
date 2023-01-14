public class UserQuestion
{
    public List<string> _questionList = new List<string>();

    public string _questionPrompt;

    public void addingPrompt()
    {
        _questionList.Add(_questionPrompt);
    }
    public string DisplayQuestion()
    {
        
        
        
        var question = new Random();
        int index = question.Next(_questionList.Count);
        string RandomeQestion = _questionList[index];

        return RandomeQestion;
        
    }
}