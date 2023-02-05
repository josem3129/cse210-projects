public class EternalGoal : GoalsDescription
{
    public override string RecordEvent()
    {
        
       int total = _pointsEarned + _totalScore;
        return total.ToString();
    }
    public override string DisplayGoal()
    {
        return $"[] {_typeOfGoal}: {_goalName},{_goalInfo}";
    }
       public override string SaveToFile()
    {
        return $"{_typeOfGoal}: {_goalName},{_goalInfo},{_scoreGoal}";
    }
}