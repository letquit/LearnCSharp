using System;
using System.Collections.Generic;
using UnityEngine;

public class NullConditionalOperators : MonoBehaviour
{
    private void Start()
    {
        // Player player = null;
        Player player = new Player();
        Debug.Log(player?.GetPlayerName());
        Debug.Log(player?.playerName);
        player?.target?.TakeDamage();

        // List<string> playerNameList = null;
        List<string> playerNameList = new List<string> { "Code Monkey" };
        Debug.Log(playerNameList?[0]);

        List<Player> playerList = new List<Player>() { null };
        // List<Player> playerList = new List<Player>() { new Player() };
        playerList?[0]?.TakeDamage();

        // int i = 5;
        // i?.CompareTo();
        int? i = 5;
        i?.ToString();
    }

    public class Player
    {
        public event EventHandler OnDamaged;

        public string playerName;
        public Player target;
        
        public void TakeDamage()
        {
            OnDamaged?.Invoke(this, EventArgs.Empty);
        }

        public string GetPlayerName()
        {
            return "Code Monkey";
        }
    }
}
