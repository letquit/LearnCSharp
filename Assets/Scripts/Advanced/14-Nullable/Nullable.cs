using System;
using UnityEngine;

public class Nullable : MonoBehaviour
{
    private void Start()
    {
        Player player = null;
        // int i = null;
        // int? i = null;
        bool? b;
        Data? data = null;
        
        int? a = null;
        int b1 = a ?? 56;
        
        // int? i = null;
        Nullable<int> i = null;
        Debug.Log(i.GetValueOrDefault(12));
        // if (i != null)
        if (i.HasValue)
        {
            // int attackDamage = (int)i;
            int attackDamage = i.Value;
        }
    }

    public struct Data
    {
        
    }
    
    public class Player
    {
        public int? attackDamage = null;

        public void Setup(int? startingHealth = null)
        {
            
        }
    }
}
