using System;
using System.Collections.Generic;
using UnityEngine;

public class Intermediate : MonoBehaviour
{
    private static Player playerTest;
    
    public void Start()
    {
        Unit unit = new Unit();
        Player player = new Player("Code Monkey");
        Enemy enemy = new Enemy();
        unit.Move();
        player.Move();
        enemy.Move();
        Debug.Log(player);

        // Player playerTwo = enemy;
        Player playerTwo = player;
        Unit unitOne = unit;
        player.MovePlayer();
        
        Unit unitTwo = player;
        // unitTwo.MovePlayer();
        unitTwo.Move();
        
        List<Unit> unitList = new List<Unit>
        {
            unit,
            player,
            enemy,
        };

        // unitTwo.speed;

        MyFunction();
        GC.Collect();
        // MyFunctionTwo();
    }

    private void MyFunction()
    {
        // Player player = new Player("Iron Man");
        Intermediate.playerTest = new Player("Iron Man");
        playerTest.Move();
    }

    private void MyFunctionTwo()
    {
        while (true)
        {
            
        }
    }

    public class Player : Unit
    {
        private string playerName;
        
        public Player(string playerName)
        {
            this.playerName = playerName;
            speed = 5;
            // Move();
        }

        ~Player()
        {
            Debug.Log("Player Desctructor");
        }
        
        public override void Move()
        {
            Debug.Log("Move Player");
        }

        // public override void Attack()
        // {
        //     
        // }

        public override string ToString()
        {
            return "Player: " + playerName;
        }
        
        public void MovePlayer()
        {
            
        }
    }
    
    // public class EnemyMeleeBoss : EnemyMelee {}
    //
    // public class EnemyMelee : Enemy {}
    
    // public class Enemy : Unit, Unit2
    public class Enemy : Unit
    {
        public override void Move()
        {
            Debug.Log("Move Enemy");
        }

        // public override void Attack()
        // {
        //     
        // }
    }
    
    // public abstract class Unit
    public class Unit
    // public sealed class Unit
    {
        protected float speed;

        public virtual void Move()
        {
            Debug.Log("Move Unit");

            // MovePlayer();
        }

        // public abstract void Attack();
    }
    
    public class Unit2
    {
        protected float speed;

        public virtual void Move()
        {
            speed = 5;
            Debug.Log("Move Unit");
        }
    }
}
