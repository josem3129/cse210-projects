public class UserQuestion
{
    public List<string> QuestionList = new List<string>();

    public string Question;

    public string DisplayQuestion()
    {
        
        
        QuestionList.Add("Who was the most interesting person I interacted with today?");
        QuestionList.Add("What was the best part of my day?");
        QuestionList.Add("How did I see the hand of the Lord in my life today?");
        QuestionList.Add("What was the strongest emotion I felt today?");
        QuestionList.Add("If I had one thing I could do over today, what would it be?");
        var question = new Random();
        int index = question.Next(QuestionList.Count);
        string RandomeQestion = QuestionList[index];

        return RandomeQestion;
        
    }
}