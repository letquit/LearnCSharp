using System;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class AssertTests : MonoBehaviour
{
    private void Start()
    {
        // new Player("CodeMonkey");
        // new Player(null);
        try
        {
            Player player = new Player(null);
            player.GetPlayerNameLength();
            // Test succeeded
            Debug.Log("Test succeeded");
        }
        catch (Exception e)
        {
            // Test failed
            Debug.Log("Test failed");
        }
    }

    private class Player
    {
        private string playerName;

        public Player(string playerName)
        {
            if (playerName == null)
                playerName = "";
            Debug.Assert(playerName != null);
            // 发布版本会断言
            Trace.Assert(playerName != null);
            this.playerName = playerName;
        }

        public int GetPlayerNameLength()
        {
            return playerName.Length;
        }
    }
}
