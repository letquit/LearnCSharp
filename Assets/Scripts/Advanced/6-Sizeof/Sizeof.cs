using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Sizeof : MonoBehaviour
{
    private void Start()
    {
        int i = 5;
        
        Debug.Log(sizeof(int));
        Debug.Log(sizeof(bool));
        Debug.Log(sizeof(ushort));
        Debug.Log(sizeof(long));
        // Debug.Log(sizeof(Player));
        // Debug.Log(Marshal.SizeOf(new Player()));
        Debug.Log(Marshal.SizeOf(typeof(Point)));
    }

    public struct Point
    {
        public int x;
        public int y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public class Player
    {
        public int speed;

        // public List<int> intList;

        public bool IsGrounded()
        {
            return true;
        }
    }
}
