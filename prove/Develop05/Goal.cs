abstract class Goal
{
    private string _name;
    private string _discription;
    private bool _status;
    private int _points;
    private string _goalType;
    public Goal(string name, string discription, int points, bool status)
    {
        _name = name;
        _discription = discription;
        _status = status;
        _points = points;
    }
    public void SetName()
    {
        Console.Write("What is the name of your goal?: ");
        _name = Console.ReadLine();
    }
    public void SetDiscription()
    {
        Console.Write("Write a short discription for your Goal: ");
        _discription = Console.ReadLine();
    }
    public void SetPoints()
    {
        Console.Write("How many points is this worth?: ");
        _points = int.Parse(Console.ReadLine());
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetGoalType(string type)
    {
        _goalType = type;
    }
    public void MarkDone()
    {
        _status = true;
    }
    public override string ToString()
    {
        string statusMarker = " ";
        if (_status)
        {
            statusMarker = "X";
        }
        return $"[{statusMarker}]{_goalType} Goal, {_name}, {_discription}, worth {_points} points";
    }
    public virtual string ToFile()
    {
        return $"{_goalType}#{_name}#{_discription}#{_points}#{_status}";
    }


    public abstract void RunActivity();
    public abstract int ReportEvent();
}