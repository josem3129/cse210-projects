public class mathAssignment : assigment
{
    private string _textbookSection;
    private string _problem;

    public string GetTextBookSection()
    {
        return _textbookSection;
    }

    public void SetTextBookSection(string textbooksection)
    {
        _textbookSection = textbooksection;
    }

    public string GetProblem()
    {
        return _problem;
    }

    public void SetProblem (string problem)
    {
        _problem = problem;
    }

    public string GetHomeworkList()
    {
        return $"{GetSummary()} {_textbookSection} {_problem}";
    }
}