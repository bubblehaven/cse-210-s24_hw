class RunningTraining : Training
{
    private float _distance;
    public RunningTraining(float minutes, float distance) : base(minutes)
    {
        _distance = distance;
    }
    public override string GetDistSpeedPace()
    {
        return $"Distance: {_distance} miles, Speed: {60*_distance/GetLength()} mph, Pace: {GetLength()/_distance} min/mile";
    }
}