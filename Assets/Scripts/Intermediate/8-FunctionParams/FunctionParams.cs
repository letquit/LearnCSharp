using System;
using System.Collections.Generic;
using UnityEngine;

public class FunctionParams : MonoBehaviour
{
    private void Start()
    {
        PrintPlayerName(31, "Code Monkey", "Iron Man");
        PrintPlayerName(31, "Code Monkey");
        PrintPlayerName(31);
    }

    // private void PrintPlayerName(params string[] playerNameArray)
    // private void PrintPlayerName(params List<string> playerNameArray)
    // private void PrintPlayerName(params string[,] playerNameArray)
    private void PrintPlayerName(int age, params string[] playerNameArray)
    {
        Debug.Log(playerNameArray.Length);
    }
    
    // private void PrintPlayerName(string playerName, string playerName2)
    // {
    //     Debug.Log(playerName);
    // }
}
