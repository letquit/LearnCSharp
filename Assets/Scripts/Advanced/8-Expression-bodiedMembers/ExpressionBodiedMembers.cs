using System;
using UnityEngine;

public class ExpressionBodiedMembers : MonoBehaviour
{
    private void Start()
    {
        
    }

    public class Player
    {
        private string playerName;

        public string PlayerName
        {
            get => playerName;
            set => playerName = value;
        }
        
        // just one parameter
        public Player(string playerName, Vector3 position) => this.playerName = playerName;
        
        public Player(string playerName) => this.playerName = playerName;
        
        public string GetPlayerName() => playerName;
        
        // public string GetPlayerName()
        // {
        //     return playerName;
        // }
        public void SetPlayerName(string playerName) => this.playerName = playerName;
    }

    public class Level
    {
        private GridSystem gridSystem;
        
        public void SEtPosition(int x, int y) => gridSystem.SetPosition(x, y);
    }

    public class GridSystem
    {
        public void SetPosition(int x, int y)
        {
            // ...
        }
    }
}
