using System;

public class StopWatch
{
    private bool _isRunning =  false;
	public StopWatch()
	{
        _isRunning = false;
    }

    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }

    public void StartStopWatch()
    {
        if (_isRunning == false)
        {
            StartTime = DateTime.Now;
            var mTimeSpan = new TimeSpan(this.StartTime.Hour, this.StartTime.Minute, this.StartTime.Second);
            _isRunning = true;
        }
        else
        {
            throw new InvalidOperationException("The Stopwatch is already running");
        }
    }

    public void StopStopWatch()
    {
        EndTime = DateTime.Now;
        var mTimeSpan = new TimeSpan(this.EndTime.Hour, this.EndTime.Minute, this.EndTime.Second);
        _isRunning = false;
    }

    public void CalculateElapsedTime()
    {
        var mTimeSpan = this.EndTime - this.StartTime;
        Console.WriteLine("Time Passed = {0}", mTimeSpan);
    }
}
