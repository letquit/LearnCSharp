using System;
using UnityEngine;

public unsafe class UnsafePointers : MonoBehaviour
// public class UnsafePointers : MonoBehaviour
{
    private unsafe void Start()
    // private void Start()
    {
        unsafe
        {
            int* intArrayPtr = stackalloc int[10];
            intArrayPtr += 5;
            // for (int i = 0; i < 20; i++)
            for (int i = 0; i < 10; i++)
            {
                Debug.Log(intArrayPtr[i]);
            }
            Debug.Log(((IntPtr)intArrayPtr).ToString("x"));
            
            GameData gameData = new GameData();
            GameData* gameDataPtr = &gameData;
            gameDataPtr->coins = 12;
            gameDataPtr->isGameOver = false;
            
            int a = 5;
            PowerTwo(&a);
            Debug.Log(a);
            
            byte[] bytes = new byte[] { 1, 2, 3, 4, 5 };
            fixed (byte* bytePtr = bytes)
            {
                
            }
        }
    }

    public struct GameData
    {
        public int coins;
        public bool isGameOver;
    }

    public static unsafe void PowerTwo(int* value)
    {
        *value *= *value;
    }
}
