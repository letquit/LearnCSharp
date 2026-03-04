using UnityEngine;
using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;

public class HFCompilerServices : MonoBehaviour
{
    private ILogger logger = new UnityLogger();
    
    private void Start()
    {
        // Log("Hello from Start");
        logger.Log("Hello from Start");
        DoSomething();
        
        ShowFormatted(5);
        ShowFormatted(-5);
        ShowFormatted(0);
    }

    private void ShowFormatted(int value)
    {
        string format = "##;(##);**Zero**";
        string result = value.ToString(format);
        logger.Log($"Input: {value} -> Formatted: {result}");
    }
    
    private void DoSomething()
    {
        // Log("Doing something important");
        logger.Log("Doing something important");
    }
    
    // private void Log(string message,
    //     [CallerMemberName] string member = "",
    //     [CallerFilePath] string file = "",
    //     [CallerLineNumber] int line = 0)
    // {
    //     Debug.Log($"[{System.IO.Path.GetFileName(file)} : {line} - {member}] {message}");
    // }
}
