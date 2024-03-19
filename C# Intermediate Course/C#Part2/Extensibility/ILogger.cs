namespace C_Part2.Extensibility;

public interface ILogger
{
    void LogError(string message);
    void LogInfo(string message);
}