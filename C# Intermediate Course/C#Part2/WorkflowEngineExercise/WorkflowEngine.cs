using System;

public class WorkflowEngine
{
    private readonly IWorkflow _workflow;

    public WorkflowEngine(IWorkflow workflow)
    {
        _workflow = workflow;
    }

    public void Run()
    {
        List<string> activities = ["Eat", "Sleep", "Exercise"];
        List<string> videoActivities =
        [
            "Upload a video to a cloud storage",
            "Call a web service provided by a third - party video encoding service.",
            "Set status to 'Encoding'",
            "Send an email notification to owner.",
            "Set status to 'Processing'",
        ];
        _workflow.Execute(videoActivities);
    }
}