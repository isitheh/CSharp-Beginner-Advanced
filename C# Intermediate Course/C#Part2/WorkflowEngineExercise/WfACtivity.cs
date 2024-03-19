using System.Diagnostics;

namespace C_Part2.WorkflowEngineExercise;

public class WfACtivity : IWorkflow
{
    public void Execute(List<IActivity> listOfActivities)
    {
        foreach (var activity in listOfActivities)
        {
            Console.WriteLine("Executing {0} ", activity);
        }
    }
}
