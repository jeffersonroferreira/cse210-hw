class Simple : Goal
{

    public Simple(string name, string discription, int points, bool status) : base(name, discription, points, status)
    { }
    public Simple() : base("", "", 0, false)
    { }
    public override void RunActivity()
    {
        SetName();
        SetDiscription();
        SetPoints();
        SetGoalType("Simple");
    }
    public override int ReportEvent()
    {
        MarkDone();
        return GetPoints();
    }
    
}