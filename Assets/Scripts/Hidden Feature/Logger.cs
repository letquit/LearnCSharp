using UnityEngine;

using System.Runtime.CompilerServices;

public interface ILogger
{
    void LogInfo(string message);
    void LogWarn(string message);
    void LogError(string message);

    void Log(string message,
        [CallerMemberName] string member = "",
        [CallerFilePath] string file = "",
        [CallerLineNumber] int line = 0)
    {
        Debug.Log($"[{System.IO.Path.GetFileName(file)} : {line} - {member}] {message}");
    }
}

public class UnityLogger : ILogger
{
    public void LogInfo(string message) => Debug.Log($"[INFO] {message}");
    public void LogWarn(string message) => Debug.LogWarning($"[WARN] {message}");
    public void LogError(string message) => Debug.LogError($"[ERROR] {message}");
}

public class FileLogger : ILogger
{
    public void LogInfo(string message) => WriteToFile($"[INFO] {message}");
    public void LogWarn(string message) => WriteToFile($"[WARN] {message}");
    public void LogError(string message) => WriteToFile($"[ERROR] {message}");
    
    private void WriteToFile(string message)
    {
        // TODO: Implement file writing logic
    }
}
