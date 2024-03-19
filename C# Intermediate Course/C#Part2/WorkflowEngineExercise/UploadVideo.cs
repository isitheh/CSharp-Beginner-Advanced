namespace C_Part2.WorkflowEngineExercise;

public class UploadVideo: IActivity
{
    public void DoActivity()
    {
        Console.WriteLine("Upload a video.");
    }
}

public class BusyStatus : IActivity
{
    public void DoActivity()
    {
        Console.WriteLine("Set Status to Busy.");
    }
}

public class ServerExchange : IActivity
{
    public void DoActivity()
    {
        Console.WriteLine("Perform Server Function.");
    }
}

public class MarkCompletion : IActivity
{
    public void DoActivity()
    {
        Console.WriteLine("Done.");
    }
}