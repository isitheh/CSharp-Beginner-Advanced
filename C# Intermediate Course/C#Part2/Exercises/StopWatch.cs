using System;

public class StopWatch
{
    private bool _isRunning;
	public StopWatch()
	{
        _isRunning = false;
    }

    private DateTime _startTime;
    private DateTime _endTime;

    public void StartStopWatch()
    {
        if (_isRunning)
        {
            throw new InvalidOperationException("The Stopwatch is already running");
        }

        _startTime = DateTime.Now;
        var mTimeSpan = new TimeSpan(this._startTime.Hour, this._startTime.Minute, this._startTime.Second);
        _isRunning = true;
    }

    public void StopStopWatch()
    {
        _endTime = DateTime.Now;
        var mTimeSpan = new TimeSpan(this._endTime.Hour, this._endTime.Minute, this._endTime.Second);
        _isRunning = false;
    }

    public void CalculateElapsedTime()
    {
        Console.WriteLine("Time Passed = {0}", (this._endTime - this._startTime));
    }
}
