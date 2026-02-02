 using System;
 using Unity.VisualScripting;
 using UnityEngine;

public class Interfaces : MonoBehaviour
{
    private void Start()
    {
        IAttackable attackable = new Player();
        // attackable.Damage();
        AttackObject(new Player());
        AttackObject(new Enemy());
    }

    private void AttackObject(IAttackable attackable)
    {
        attackable.Damage();
        attackable.Eat();
    }

    public class Player : IAttackable, IMovable, IHasInventory
    {
        public void Damage()
        {
            Debug.Log("Player damage");
        }
    }

    public class Enemy : IAttackable, IMovable
    {
        public void Damage()
        {
            Debug.Log("Enemy damage");
        }
    }
    
    public interface IAttackable
    {
        // public int health;
        // public int Health { get; set; }
        public void Damage();

        public void Eat()
        {
            Debug.Log("Eat");
        }
    }
    
    public interface IMovable
    {
    }
    
    public interface IHasInventory
    {
        
    }
}
