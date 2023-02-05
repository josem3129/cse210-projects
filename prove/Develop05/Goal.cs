public abstract class GoalsDescription 
{
    protected string _typeOfGoal;
    protected string _goalName;

    protected string _goalInfo;

    protected string _scoreGoal;

    

    protected List<string> _goalMadeList;
    

    protected int _totalScore;

    protected int _pointsEarned;

    
    public int GetPointsEarned()
    {
        return _pointsEarned;
    }
    public void SetPointsEarned(int pointsEarned)
    {
        _pointsEarned = pointsEarned;
    } 


    public int GetTotalGoal()
    {
        return _totalScore;
    }
    public void SetTotalGoal(int totalGoal)
    {
        _totalScore = totalGoal;
    }

    public string GetTypeOfGoal()
    {
        return _typeOfGoal;
    }
    public void SetTypeOfGoal(string typeOfGoal)
    {
        _typeOfGoal = typeOfGoal;
    }

    public List<string> GetGoalMadeList()
    {
        return _goalMadeList;
    }
    public void SetGoalMadeList(List<string> goalsMade)
    {
        _goalMadeList = goalsMade;
    }
    public string GetGoalName()
    {
        return _goalName;
    }
    public void SetGoalName(string goalName)
    {
        _goalName = goalName;
    }

     public string GetGoalInfo()
    {
        return _goalInfo;
    }
    public void SetGoalInfo(string goalInfo)
    {
        _goalInfo = goalInfo;
    }
     public string GetScoreGoal()
    {
        return _scoreGoal;
    }
    public void SetScoreGoal(string scoreGoal)
    {
        _scoreGoal = scoreGoal;
    }
    

    // public abstract int AddGoal();
    public abstract string DisplayGoal();
    public abstract string RecordEvent();
    public abstract string SaveToFile();
    public virtual void DisplayDone()
    {

    }
    public virtual void IsComplete()
    {

    }

    

}
