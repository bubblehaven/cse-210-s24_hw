class CyclingTraining : Training
{
    private float _speed;
    public CyclingTraining(float minutes, float speed) : base(minutes)
    {
        _speed = speed;
    }
    public float GetSpeed()
    {
        return _speed;
    }
    public override string GetDistSpeedPace()
    {
        return $"Distance: {_speed * GetLength()/60} miles, Speed: {_speed} mph, Pace: {1 / (60*_speed)} min/mile";
    }
}