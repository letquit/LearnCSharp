using System;
using UnityEngine;

public class Default : MonoBehaviour
{
    private void Start()
    {
        int i = 1;

        // switch (i)
        // {
        //     default:
        //         break;
        //     case 56:
        //         break;
        // }
        Debug.Log(default(int));
        Debug.Log(default(bool));
        Debug.Log(default(Player));
        
        float f = default;
        Debug.Log(f);
        
        Debug.Log(new Box<int>().GetDefault());
        Debug.Log(new Box<bool>().GetDefault());
        Debug.Log(new Box<Player>().GetDefault());
    }

    public class Box<T>
    {
        public T GetDefault()
        {
            return default(T);
        }
    }
    
    public class Player
    {
        public int speed;

        public void SetSpeed(out bool isSet, int speed = default(int))
        {
            this.speed = speed;
            isSet = default;
        }
        
        public bool IsGrounded()
        {
            return true;
        }
    }
}
