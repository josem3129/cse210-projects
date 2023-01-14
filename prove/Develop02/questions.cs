public class UserQuestion
{
    public List<string> _QuestionList = new List<string>();

    public string _questionPrompt;

    public void addingPrompt()
    {
        _QuestionList.Add(_questionPrompt);
    }
    public string DisplayQuestion()
    {
        
        
        
        var question = new Random();
        int index = question.Next(_QuestionList.Count);
        string RandomeQestion = _QuestionList[index];

        return RandomeQestion;
        
    }
}