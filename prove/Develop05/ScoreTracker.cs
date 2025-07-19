public class ScoreTracker
{
    private int _pointTotal;
    private int _level;

    public ScoreTracker()
    {
        _pointTotal = 0;
        _level = 1;
    }
    public int GetLevel()
    {
        return _level;
    }
    public void AddPoints(int points)
    {
        _pointTotal += points;
    }
    public int GetPoints()
    {
        return _pointTotal;
    }
    public void SetPoints(int points)
    {
        _pointTotal = points;
    }
    public void CheckLevel()
    {
        if (_pointTotal >= 355000)
        {
            _level = 20;
        }
        else if (_pointTotal < 355000 && _pointTotal > 305000)
        {
            _level = 19;
        }
        else if (_pointTotal > 265000)
        {
            _level = 18;
        }
        else if (_pointTotal > 225000)
        {
            _level = 17;
        }
        else if (_pointTotal > 195000)
        {
            _level = 16;
        }
        else if (_pointTotal > 165000)
        {
            _level = 15;
        }
        else if (_pointTotal > 140000)
        {
            _level = 14;
        }
        else if (_pointTotal > 120000)
        {
            _level = 13;
        }
        else if (_pointTotal > 100000)
        {
            _level = 12;
        }
        else if (_pointTotal > 85000)
        {
            _level = 11;
        }
        else if (_pointTotal > 64000)
        {
            _level = 10;
        }
        else if (_pointTotal > 48000)
        {
            _level = 9;
        }
        else if (_pointTotal > 34000)
        {
            _level = 8;
        }
        else if (_pointTotal > 23000)
        {
            _level = 7;
        }
        else if (_pointTotal > 14000)
        {
            _level = 6;
        }
        else if (_pointTotal > 6500)
        {
            _level = 5;
        }
        else if (_pointTotal > 2700)
        {
            _level = 4;
        }
        else if (_pointTotal > 900)
        {
            _level = 3;
        }
        else if (_pointTotal > 300)
        {
            _level = 2;
        }
        else
        {
            _level = 1;
        }

    }
}