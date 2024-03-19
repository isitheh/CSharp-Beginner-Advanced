using C_Part2.Extensibility;
using System;

public interface IWorkflow
{
    void Execute(List<string> activityList);
}