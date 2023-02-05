public class ChecklistGoal : GoalsDescription
{
    private string _bonusPoints;
    private string _amountOftimes;
    private string _amountOftimesDone;
    private List<string> _goalsRecordedList;

      public string GetAmountOftimesDone()
    {
        return _amountOftimesDone;
    }
    public void SetAmountOftimessDone(string amountOftimesDone)
    {
        _amountOftimesDone = amountOftimesDone;
    }    

    public List<string> GetGoalRecordedList()
    {
        return _goalsRecordedList;
    }
    public void SetGoalsRecordedList(List<string> goalsRecordedList)
    {
        _goalsRecordedList = goalsRecordedList;
    } 
    public string GetAmountOftimes()
    {
        return _amountOftimes;
    }
    public void SetAmountOftimess(string amountOftimes)
    {
        _amountOftimes = amountOftimes;
    }
    public string GetBonusPoints()
    {
        return _bonusPoints;
    }
    public void SetBonusPoints(string bonusPoints)
    {
        _bonusPoints = bonusPoints;
    }
    public override string RecordEvent()
    {
        int total = 0;
        if (_amountOftimes == _amountOftimesDone)
            {
                total = _pointsEarned + _totalScore + int.Parse(_bonusPoints);
                
            }
        else if (_amountOftimes != _amountOftimesDone)
            {
                total = _pointsEarned + _totalScore;
                _goalsRecordedList.Add(_goalName);
            }
        return total.ToString();
    }
       
    public override string DisplayGoal()
    {
        int amount = _goalsRecordedList.Count();
        return $"{_goalName}({_goalInfo}) - {_amountOftimes}\\/ {amount.ToString()}";


    }

     public override void DisplayDone()
    {
        
        if (_amountOftimes == _amountOftimesDone)
            {
                int amount = _goalsRecordedList.Count();   
                Console.WriteLine($"[X]{_goalName}({_goalInfo}) - {_amountOftimes}\\/ {amount.ToString()}");
                
                
            }
        else if (_amountOftimes != _amountOftimesDone)
            {
                int amount = _goalsRecordedList.Count();   
                Console.WriteLine($"[ ]{_goalName}({_goalInfo}) - {_amountOftimes}\\/ {amount.ToString()}");
                
            }
        
    }

    public override string SaveToFile()
    {
        int amount = _goalsRecordedList.Count();
        return $"{_typeOfGoal}: {_goalName},{_goalInfo},{_scoreGoal},{_bonusPoints},{_amountOftimes},{amount.ToString()}";
    }
}