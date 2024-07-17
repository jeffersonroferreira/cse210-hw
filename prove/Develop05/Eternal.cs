class Eternal : Goal
{
    private int _timesCompleted = 0;
    public Eternal(string name, string discription, int points, bool status, int timesCompleted) : base(name, discription, points, status)
    {
        _timesCompleted = timesCompleted;
    }
    public Eternal() : base("", "", 0, false)
    { }
    public override void RunActivity()
    {
        SetName();
        SetDiscription();
        SetPoints();
        SetGoalType("Eternal");
    }
    public override string ToString()
    {
        return $"{base.ToString()} times completed: {_timesCompleted}";
    }
    public override string ToFile()
    {
        return $"{base.ToString()} times completed: {_timesCompleted}";
    }

    public override int ReportEvent()
    {
        _timesCompleted += 1;
        return GetPoints();
    }
}