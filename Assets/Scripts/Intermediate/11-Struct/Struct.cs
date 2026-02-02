using System;
using UnityEngine;

public class Struct : MonoBehaviour
{
    private void Start()
    {
        PlayerStruct playerStruct = new PlayerStruct();
        playerStruct.a = 1;
        PlayerClass playerClass = new PlayerClass();
        playerClass.a = 1;
        
        TestFunctionStruct(playerStruct);
        TestFunctionClass(playerClass);
        
        Debug.Log("playerStruct " + playerStruct.a);
        Debug.Log("playerClass " + playerClass.a);
        
        Vector3 position = new Vector3(10, 21, 10);
        position.Normalize();
        Debug.Log(position);
        
        // Player player = new Player();
        Player player = new Player()
        {
            a = 2,
        };
        // Player player = default;
        Debug.Log(player);
        Debug.Log(player.a);
    }

    private void TestFunctionStruct(PlayerStruct playerStruct)
    {
        playerStruct.a = 2;
    }
    
    private void TestFunctionClass(PlayerClass playerClass)
    {
        playerClass.a = 2;
    }

    public struct PlayerStruct
    {
        public int a;
    }
    
    public class PlayerClass
    {
        public int a;
    }

    public class Unit : BaseClass
    {
        
    }
    
    public struct Player
    // public class Player
    // public struct Player : BaseClass
    {
        public int a;

        public Player(int a)
        {
            this.a = a;
        }
    }
    
    public class BaseClass
    {
        
    }
}
