using C_Part2.Extensibility;
using System;
using C_Part2.WorkflowEngineExercise;

public interface IWorkflow
{
    void Execute(List<IActivity> listOfActivities);
}