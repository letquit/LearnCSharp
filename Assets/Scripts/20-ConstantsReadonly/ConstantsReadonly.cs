using System;
using UnityEngine;

public class ConstantsReadonly : MonoBehaviour
{
    private const float PLAYER_SPEED = 5f;
    // private float PLAYER_SPEED = 5f;
    // private const float PLAYER_SPEED;
    
    // private const Player player = new Player();
    private readonly Player player = new Player(100);
    // private readonly int player = new Player();
    
    private void Start()
    {
        int age;
        age = 5;
        age = 7;

        // player = new Player();
        
        // Math.PI = 3;
        Debug.Log(PLAYER_SPEED);
    }

    public class Player
    {
        private readonly int healthMax;

        public Player(int healthMax)
        {
            this.healthMax = healthMax;
        }
    }
}
