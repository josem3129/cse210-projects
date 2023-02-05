public class SimpleGoal : GoalsDescription
{
    private bool _goalDone;

    private int _index;
    
    public int GetIndex()
    {
        return _index;
    }
    public void SetIndex(int index)
    {
        _index = index;
    }
    public bool GetGoalDone()
    {
        return _goalDone;
    }
    public void SetGoaldone(bool goalDone)
    {
        _goalDone = goalDone;
    } 
    public override void IsComplete()
    {
        Console.WriteLine(_goalDone);        
    }
    
    public override string RecordEvent()
    {
        _goalMadeList.RemoveAt(_index);
       _goalMadeList.Add($"{_typeOfGoal}: {_goalName},{_goalInfo},{_scoreGoal},{_goalDone = true}");
       int total = _pointsEarned + _totalScore;
        return total.ToString();
    }
    public override string DisplayGoal()
    {
        return $"[] {_goalName} ({_goalInfo})";
    }

    public override void DisplayDone()
    {
        Console.WriteLine($"[X] {_goalName},{_goalInfo}");
    }

    public override string SaveToFile()
    {
        return $"{_typeOfGoal}: {_goalName},{_goalInfo},{_scoreGoal},{_goalDone}";
    }

}