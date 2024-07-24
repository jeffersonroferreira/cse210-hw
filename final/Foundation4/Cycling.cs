class Cycling : Activity
{
    private double _speed;
    public Cycling(string date, int lengthMinutes, double speed) : base(date, lengthMinutes)
    {
        _speed = speed;
    }
    private double Distance(int time, double speed)
    {
        return speed / 60.0 * time;
    }
    public override void GetSummary()
    {
        double dis = Distance(GetTime(), _speed);
        base.GetSummary();
        Console.WriteLine($"- Distance {dis} Miles, Speed {_speed}mph, Pace {Pace(dis, GetTime())} min per mile");
    }
}