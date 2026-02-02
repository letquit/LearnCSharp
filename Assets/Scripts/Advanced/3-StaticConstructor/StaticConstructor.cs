using System;
using UnityEngine;

public class StaticConstructor : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(Player.i);
        Player.TestFunction();
        
        Player player = new Player();
    }

    public class Player
    {
        static Player()
        {
            Debug.Log("Player Static Constructor");
            i = 56;
        }

        public static int i;
        
        public static void TestFunction()
        {
            Debug.Log("TestFunction");
        }

        public int j = 12;
        
        public Player()
        {
            j = 12;
            Debug.Log("Player Constructor");
        }
    }
}
