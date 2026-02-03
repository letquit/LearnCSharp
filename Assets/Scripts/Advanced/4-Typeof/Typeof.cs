using System;
using UnityEngine;

public class Typeof : MonoBehaviour
{
    private void Start()
    {
        // typeof(Player);
        // GetComponent<Player>();
        // GetComponent(Player);
        
        Player player = new Player();
        player.GetType();
        GetComponent(typeof(Player));
    }

    public class Player
    {
        
    }
}
