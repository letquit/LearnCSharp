using System;
using UnityEngine;

public class SwitchTypeMatching : MonoBehaviour
{
    private void Start()
    {
        IAttackable attackable = new Player()
        {
            health = 100
        };

        // if (attackable is Player) { }
        // if (attackable is Enemy) {}
        // if (attackable is RedBarrel) {}
        switch (attackable)
        {
            case Player player when player.health > 50:  
                Debug.Log("Health 50");
                player.PlayerSayHello();
                break;
            case Player player:  
                player.PlayerSayHello();
                break;
            case Enemy enemy:
                break;
            case RedBarrel barrel:
                break;
            default:
                break;
        }
    }

    public class Player : Unit, IAttackable, IMovable, IHasInventory
    {
        public int health;
        
        public void Damage()
        {
            Debug.Log("Player damage");
        }

        public void PlayerSayHello()
        {
            Debug.Log("Player say hello");
        }
    }

    public class Enemy : Unit, IAttackable, IMovable { }
    
    public class RedBarrel : Unit, IAttackable, IMovable { }

    public class Unit
    {
        
    }
    
    public interface IAttackable
    {
        public void Damage()
        {
            Debug.Log("Damage");
        }
    }
    
    public interface IMovable { }
    
    public interface IHasInventory { }
}
