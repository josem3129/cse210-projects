public class SimpleGoal : GoalsDescription
{
    // here we is the simple goal and is how we can show if is done with a boolian 
    private bool _goalDone;

   
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
    // if the goal was done we show with a boolian by chaning it to be true 
    public override string RecordEvent()
    {
        _goalMadeList.RemoveAt(_index);
       _goalMadeList.Add($"{_typeOfGoal}:{_goalName},{_goalInfo},{_scoreGoal},{_goalDone = true}");
       int total = _pointsEarned + _totalScore;
        return total.ToString();
    }
    //we display the goal if its done or not 
    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {_goalName} ({_goalInfo})");
    }

    public override void DisplayDone()
    {
        Console.WriteLine($"[X] {_goalName} ({_goalInfo}) ");
    }

    public override string SaveToFile()
    {
        
        return $"{_typeOfGoal}:{_goalName},{_goalInfo},{_scoreGoal},{_goalDone}";
    }

}