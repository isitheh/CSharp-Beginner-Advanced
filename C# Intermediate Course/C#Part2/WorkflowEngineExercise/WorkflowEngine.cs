using System;
using C_Part2.WorkflowEngineExercise;

public class WorkflowEngine
{
    private readonly IWorkflow _workflow;

    public WorkflowEngine(IWorkflow workflow)
    {
        _workflow = workflow;
    }

    public void Run()
    {
        List<IActivity> activities =
        [
            new UploadVideo(),
            new BusyStatus(),
            new ServerExchange(),
            new MarkCompletion()
        ];
        _workflow.Execute(activities);
    }
}