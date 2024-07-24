abstract class Activity
{
    private string _date;
    private int _lengthMinutes;
    public Activity(string date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }
    public int GetTime()
    {
        return _lengthMinutes;
    }
    public double Pace(double distance, double time)
    {
        return time / distance;
    }
    public double Speed(double pace)
    {
        return 60 / pace;
    }
    public virtual void GetSummary()
    {
        Console.Write($"{_date} {base.ToString()} ({_lengthMinutes})");
    }

}