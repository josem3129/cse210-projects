public class ChecklistGoal : GoalsDescription
{
    private string _bonusPoints;
    private string _amountOftimes;
    private string _amountOftimesDone;
    private List<string> _goalsRecordedList = new List<string>();

      public string GetAmountOftimesDone()
    {
        return _amountOftimesDone;
    }
    public void SetAmountOftimesDone(string amountOftimesDone)
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
    public void SetAmountOftimes(string amountOftimes)
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
                _goalMadeList.RemoveAt(_index);
                
            }
        else if (_amountOftimes != _amountOftimesDone)
            {
                
                
                _goalMadeList.RemoveAt(_index);
                _goalMadeList.Add($"{_typeOfGoal}:{_goalName},{_goalInfo},{_scoreGoal},{_bonusPoints},{_amountOftimes},{_amountOftimesDone}");
                total = _pointsEarned + _totalScore;
            }
        return total.ToString();
    }
       

     public override void DisplayGoal()
    {
        int amount = 0;
        
        if (_amountOftimes != _amountOftimesDone)
            {
                
                Console.WriteLine($"[ ] {_goalName}({_goalInfo}) - {_amountOftimesDone}/{_amountOftimes}");
                
                
            }
        else if (_amountOftimes == _amountOftimesDone)
            {
                 
                Console.WriteLine($"[X] {_goalName}({_goalInfo}) - {_amountOftimesDone}/{_amountOftimes}");
                
            }
        
    }

    public override string SaveToFile()
    {
        int amount = _goalsRecordedList.Count();
        return $"{_typeOfGoal}:{_goalName},{_goalInfo},{_scoreGoal},{_bonusPoints},{_amountOftimes},{amount.ToString()}";
    }
}