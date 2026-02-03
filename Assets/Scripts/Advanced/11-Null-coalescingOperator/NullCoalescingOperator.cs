using System;
using System.Collections.Generic;
using UnityEngine;

public class NullCoalescingOperator : MonoBehaviour
{
    private string playerName;
    
    private void Start()
    {
        // int playerNameLength = GetStringLength(playerName);
        
        // playerName = "Code Monkey";

        string defaultPlayerName = "DEFAULT";
        
        int playerNameLength;

        
        // if (playerName == null)
        //     playerNameLength = GetStringLength("");
        // else
        //     playerNameLength = GetStringLength(playerName);
        // playerNameLength = GetStringLength(playerName ?? "");
        // playerNameLength = GetStringLength(playerName ?? defaultPlayerName ?? "");
        playerNameLength = GetStringLength(playerName ?? throw new Exception(nameof(playerName) + " is null!"));
        
        Debug.Log(playerNameLength);

        Player player = null;

        player ??= new Player();
        
        Debug.Log(player.ToString());
        
        Debug.Log(player?.GetPlayerName() ?? "Unknown Player");

        // int i = 56;
        // int b = i ?? 20;
        int? i = 56;
        int b = i ?? 20;
    }

    private int GetStringLength(string str)
    {
        return str.Length;
    }

    private class Player
    {
        private List<Player> playerTargetList;

        public void AddTargetPlayer(Player targetPlayer)
        {
            playerTargetList ??= new List<Player>();
            
            playerTargetList.Add(targetPlayer);
        }

        public string GetPlayerName()
        {
            return "";
        }
    }
}
