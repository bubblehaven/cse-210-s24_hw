class SwimmingTraining : Training
{
    private int _laps;
    public SwimmingTraining(float minutes, int laps) : base(minutes)
    {
        _laps = laps;
    }
    public override string GetDistSpeedPace()
    {
        return $"Disance: {_laps*0.031} miles, Speed: {_laps*1.86/GetLength()} mph, Pace: {GetLength()/(_laps*0.031)}";
    }
}