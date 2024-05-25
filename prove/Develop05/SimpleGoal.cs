class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points, string isComplete)
        :base(name, description, points)
    {
        if (isComplete == "True")
        {
            _isComplete = true;
        }
        else
        {
            _isComplete = false;
        }
    }

    public override void RecordEvent()
    {
        if (_isComplete == false)
        {
            _isComplete = true;
        }
        else 
        {
            Console.WriteLine("You cannot complete this task again.");
        }
    }    
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}