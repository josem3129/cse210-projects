public class ChecklistGoal : GoalsDescription
{
    // the check list goal find the bonus poins and also the amount of times that needs to be done and the times it has been done
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
    //here we record when a goal is done and finds if the amount of times it has beens done and if it has there is bonus points. 
    public override string RecordEvent()
    {
        int total = 0;
        if (_amountOftimes == _amountOftimesDone)
            {
                total = _pointsEarned + _totalScore + int.Parse(_bonusPoints);
                                
            }
        else if (_amountOftimes != _amountOftimesDone)
            {
                _goalMadeList.RemoveAt(_index);
                _goalMadeList.Add($"{_typeOfGoal}:{_goalName},{_goalInfo},{_scoreGoal},{_bonusPoints},{_amountOftimes},{_amountOftimesDone}");
                total = _pointsEarned + _totalScore;
            }
        return total.ToString();
    }
       
// here w are also checking if the goal has been done comapring how many time its has been done to how many times needs to be done and then prints a formated goal shonig ether done or not 
     public override void DisplayGoal()
    {
        
        
        if (_amountOftimes != _amountOftimesDone)
            {
                
                Console.WriteLine($"[ ] {_goalName} ({_goalInfo}) - {_amountOftimesDone}/{_amountOftimes}");
                
                
            }
        else if (_amountOftimes == _amountOftimesDone)
            {
                 
                Console.WriteLine($"[X] {_goalName}({_goalInfo}) - {_amountOftimesDone}/{_amountOftimes}");
                
            }
        
    }
    // here is were we format the goal to send to list. 
    public override string SaveToFile()
    {
        int amount = _goalsRecordedList.Count();
        return $"{_typeOfGoal}:{_goalName},{_goalInfo},{_scoreGoal},{_bonusPoints},{_amountOftimes},{amount.ToString()}";
    }
}