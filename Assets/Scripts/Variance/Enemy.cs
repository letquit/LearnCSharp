using System;
using UnityEngine;

interface IFactory<out T>
// interface IFactory<T>
{
    T Create();
    // 无效的差异:协变式类型形参 'T' 用于逆变式位置. 参数必须为输入安全 因为已经将接口定义为协变了
    // void Register(T t); // wold make it invalid - can't use T in input position
}

public class EnemyFactory : IFactory<Enemy>
{
    public Enemy Create() => new GameObject("Enemy").AddComponent<Enemy>();
}

public class BossEnemyFactory : IFactory<Boss>
{
    public Boss Create() => new GameObject("Boss").AddComponent<Boss>();
}

public class EnemySpawner : MonoBehaviour
{
    private IFactory<Enemy> enemyFactory;

    private void Start()
    {
        enemyFactory = new BossEnemyFactory();
    }
}

public class Enemy : MonoBehaviour
{
    public int health;
}

public class Boss : Enemy
{
    public int damageMultiplier;
}