public class EternalGoal : GoalsDescription
{
    // eteranl goal class records when a goal is done 
    // here the goal also is displayed fromated 
    // and also is formated to be saved in a list to later be saved in a file. 
    public override string RecordEvent()
    {
        
        _goalMadeList.RemoveAt(_index);
        _goalMadeList.Add($"{_typeOfGoal}:{_goalName},{_goalInfo},{_scoreGoal}");
        int total = _pointsEarned + _totalScore;
        return total.ToString();
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {_goalName} ({_goalInfo})");
    }
       public override string SaveToFile()
    {
        return $"{_typeOfGoal}:{_goalName},{_goalInfo},{_scoreGoal}";
    }
}