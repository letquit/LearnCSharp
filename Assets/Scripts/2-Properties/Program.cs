using System;
using UnityEngine;

public class Program : MonoBehaviour
{
    public static string PlayerName { get; private set;}
    
    private static string playerName;
    
    // public static string PlayerName
    // {
    //     get
    //     {
    //         if (playerName == null)
    //             return "Unknown";
    //         return playerName;
    //     }
    //     private set
    //     {
    //         if (value == "Code Monkey")
    //             throw new Exception("Cannot name player Code Monkey");
    //         playerName = value;
    //     }
    // }
    
    private static void SetPlayerName(string playerName)
    {
        Program.playerName = playerName;
    }
    
    private static string GetPlayerName()
    {
        return Program.playerName;
    }
    
    public static Program Instance { get; private set; }    // 单例模式
    

    private void Start()
    {
        PlayerName = "Code Monkey";
        Debug.Log(PlayerName);
    }
}

public class Player
{
    public Player()
    {
        // Program.PlayerName = "Code Monkey";
        Debug.Log(Program.PlayerName);
    }
}
