public abstract class GoalsDescription 
{
    // here we hold alot od data 
    // we look for each part of the goal 
    protected string _typeOfGoal;
    protected string _goalName;

    protected string _goalInfo;

    protected string _scoreGoal;

    

    protected List<string> _goalMadeList;
    

    protected int _totalScore;

    protected int _pointsEarned;

    protected int _index;
    
    public int GetIndex()
    {
        return _index;
    }
    public void SetIndex(int index)
    {
        _index = index;
    }

    
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
    

    // here we have some methods that each goal share and can be molded to each need
    // there is for displaying when is done or not 
    // when they need be saved in a lisrt 
    // also when the goal needs to be recorded that it was done

    public abstract void DisplayGoal();
    public abstract string RecordEvent();
    public abstract string SaveToFile();
    public virtual void DisplayDone()
    {

    }
    public virtual void IsComplete()
    {

    }

    

}
