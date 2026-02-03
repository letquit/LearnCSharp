using System;
using UnityEngine;

public class Nameof : MonoBehaviour
{
    private void Start()
    {
        // string playerClassName = "Player";
        // playerClassName = nameof(Player);
        
        // Debug.Log(typeof(Player));
        Debug.Log(nameof(Player));
        Debug.Log(nameof(Player.speed));
        Debug.Log(nameof(Player.IsGrounded));
        
        Player player = new Player();
        player.SetSpeed(0);
        
        Debug.Log(player.GetType().Name);
    }

    public class Player
    {
        public int speed;

        public bool IsGrounded()
        {
            return true;
        }

        public void SetSpeed(int speedToSet)
        {
            if (speedToSet == 0)
                Debug.Log("ERROR: " + nameof(speedToSet) + " must not be 0");
            this.speed = speedToSet;
        }
    }
}
