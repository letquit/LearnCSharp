using System;
using UnityEngine;

public class EnumFlags : MonoBehaviour
{
    [Flags]
    // public enum Ability
    public enum Ability : byte
    {
        None = 0,
        Jump = 1 << 0,
        Sprint = 1 << 1,
        Shoot = 1 << 2,
        Fly = 1 << 3,
        // Fly2 = 1 << 4,
        // Fly3 = 1 << 5,
        // Fly4 = 1 << 6,
        // Fly5 = 1 << 7,
        // Fly6 = 1 << 8,
        ShootAndFly = Fly | Shoot,
    }
    
    private void Start()
    {
        Ability playerAbilities = Ability.Jump | Ability.Shoot;
        Debug.Log(playerAbilities);
        
        Debug.Log(playerAbilities.HasFlag(Ability.Jump));
        
        Debug.Log((Ability.Jump & playerAbilities) == Ability.Jump);
    }
}
