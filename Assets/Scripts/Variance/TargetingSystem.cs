using System;
using System.Collections.Generic;
using UnityEngine;

// public delegate void HandleTarget<T>(T target);
public delegate void HandleTarget<in T>(T target);

public class TargetingSystem : MonoBehaviour
{
    private void Start()
    {
        // List<MonoBehaviour> enemies = new List<Enemy>();    // Compiler error because List<T> is invariant
        
        List<Boss> bosses = new List<Boss>();
        // List<Enemy> enemies = bosses;   // T类型的列表是不变的
        
        // DamageAll(bosses);  // Invariance violation
        //绝大多数泛型类型都是不变的 List<T>、Dictionary<TKey, TValue>、HashSet<T> 类型参数被锁定无法改变
        
        DamageAll(bosses);  // IEnumerable是协变的 允许替换更具体的类型 但仅限于只读访问
        
        // 协变是拉出数据，逆变是推入数据
        
        HandleTarget<Enemy> enemyHandler = HandleEnemy;
        // HandleTarget<Boss> bossHandler = enemyHandler;  // 委托是默认协变
        // 当一个值仅用作输入时，你变允许你用更通用的类型来替换
        HandleTarget<Boss> bossHandler = enemyHandler;

        Boss boss = new GameObject("Boss").AddComponent<Boss>();
        boss.health = 200;
        bossHandler(boss);

    }

    private void HandleEnemy(Enemy e)
    {
        e.health -= 10; // perfectly valid
        Debug.Log($"Enemy has {e.health} HP");
    }

    // private void DamageAll(List<Enemy> enemies)
    private void DamageAll(IEnumerable<Enemy> enemies)
    {
        // enemies.Add(new Boss());
        // enemies[0] = new Boss();
        // enemies.Clear();
        
        foreach (var e in enemies)
        {
            e.health -= 10;
        }
    }
}
