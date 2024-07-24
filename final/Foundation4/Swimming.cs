class Swimming : Activity
{
    private int _laps;
    public Swimming(string date, int lengthMinutes, int laps) : base(date, lengthMinutes)
    {
        _laps = laps;
    }
    private double Distance(int laps)
    {
        return laps * 50.0 / 1000.0 * .62; 
    }
    public override void GetSummary()
    {
        double pace = Pace(Distance(_laps), GetTime());
        base.GetSummary();
        Console.WriteLine($"- Distance {Distance(_laps)} Miles, Speed {Speed(pace)}mph, Pace: {Math.Round(pace, 2)} mins per mile");
    }
}