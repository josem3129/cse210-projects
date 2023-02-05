public class EternalGoal : GoalsDescription
{
    public override string RecordEvent()
    {
        
        _goalMadeList.RemoveAt(_index);
        _goalMadeList.Add($"{_typeOfGoal}:{_goalName},{_goalInfo},{_scoreGoal}");
        int total = _pointsEarned + _totalScore;
        return total.ToString();
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {_goalName},{_goalInfo}");
    }
       public override string SaveToFile()
    {
        return $"{_typeOfGoal}:{_goalName},{_goalInfo},{_scoreGoal}";
    }
}