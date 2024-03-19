namespace C_Part2.WorkflowEngineExercise;

public class WfACtivity : IWorkflow
{
    public void Execute(List<string> activityList)
    {
        foreach (var activity in activityList)
        {
            Console.WriteLine("Executing {0} ", activity);
        }
    }
}