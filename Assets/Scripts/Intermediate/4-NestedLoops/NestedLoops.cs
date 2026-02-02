using System;
using System.Collections.Generic;
using UnityEngine;

public class NestedLoops : MonoBehaviour
{
    private void Start()
    {
        // for (int i = 0; i < 3; i++)
        // {
        //     for (int j = 0; j < 2; j++)
        //     {
        //         Debug.Log(i + ", " + j);
        //     }
        // }

        int[,] inmtArray = new int[3, 2];
        
        for (int i = 0; i < inmtArray.GetLength(0); i++)
        {
            // bool breakFromLoop = false;
            for (int j = 0; j < inmtArray.GetLength(1); j++)
            {
                Debug.Log(i + ", " + j);
                // breakFromLoop = true;
                // break;
                // if (i == 0)
                    continue;
                // Debug.Log("This will not be printed");
            }
            
            // if (breakFromLoop)
            //     break;
        }
        
        List<Player> playerList = new List<Player>();
        Player specialPlayer = new Player();
        playerList.Add(specialPlayer);
        playerList.Add(new Player());
        playerList.Add(new Player());
        playerList.Add(new Player());

        for (int i = 0; i < inmtArray.GetLength(0); i++)
        {
            for (int j = 0; j < inmtArray.GetLength(1); j++)
            {
                Debug.Log(i + ", " + j);
                foreach (Player player in playerList)
                {
                    if (player == specialPlayer)
                        continue;
                    Debug.Log(player);
                }
            }
        }
        
        // foreach (Player player in playerList)
        // {
        //     if (player == specialPlayer)
        //         continue;
        //     Debug.Log(player);
        // }
    }
    
    private class Player
    {
        
    }
}
