using System;
using UnityEngine;

public class MainAndCommandLineArgs : MonoBehaviour
{
    private void Start()
    {
        
    }
    
    // public static void Main(string[] args)
    public static void Main()
    {
        string[] args = Environment.GetCommandLineArgs();
        Debug.Log(args.Length);
        foreach (string arg in args)
        {
            Debug.Log(arg);
        }
        int.TryParse(args[0], out int argInt);
        bool.TryParse(args[2], out bool argBool);
        
        Debug.Log(argInt);
        Debug.Log(args[1]);
        Debug.Log(argBool);
    }
}

// public class AnotherProgram
// {
//     public static void Main()
//     {
//         
//     }
// }
