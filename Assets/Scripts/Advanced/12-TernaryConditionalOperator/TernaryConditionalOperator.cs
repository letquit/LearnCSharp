using System;
using UnityEngine;

public class TernaryConditionalOperator : MonoBehaviour
{
    private void Start()
    {
        Player player = new Player();
        
        player.health = 100;
        Debug.Log(player.GetPlayerStateString());
        player.health = 0;
        Debug.Log(player.GetPlayerStateString());
    }

    private class Player
    {
        public int health;

        public string GetPlayerStateString()
        {
            return health > 0 ? "ALIVE" : "DEAD";
            
            int i = health > 0 ? HandlePlayerLogic() : DoNothing();
            
            if (health > 0)
            {
                return "ALIVE";
            }
            else
            {
                return "DEAD";
            }
        }

        private int HandlePlayerLogic()
        {
            return 0;
        }

        private int DoNothing()
        {
            return 0;
        }
    }
}
