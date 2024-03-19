using C_Part2.Extensibility;
using System.IO;

public class FileLogger : ILogger
{
    private readonly string _path;

    public FileLogger(string path)
    {
        _path = path;
    }
    public void LogError(string message)
    {
        Log(message, "ERROR");
    }

    public void LogInfo(string message)
    {
        Log(message, "INFO");
    }

    private void Log(string message, string messageType)
    {
        using (var streamWrite = new StreamWriter(_path, true))
        {
            streamWrite.WriteLine(messageType + ": " + message);
        }
    }
}