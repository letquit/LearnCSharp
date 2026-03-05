using System;
using UnityEngine;

// public delegate void TargetHandler<T>(T target);
public delegate void TargetHandler<in T>(T target);
public delegate T SelectTarget<out T>();
// 接口和委托是不变的，除非明确标记在内部或外部
public delegate T BadSelector<T>(T candidate);
// public delegate T BadSelector<in T>(T candidate);   // 无效的差异:逆变式类型形参 'T' 用于协变式位置. 委托返回值类型必须为输出安全
// public delegate T BadSelector<out T>(T candidate);  // 无效的差异:协变式类型形参 'T' 用于逆变式位置. 参数必须为输入安全
public delegate T InvariantSelector<T>(T candidate);

public class OtherTargetingSystem : MonoBehaviour
{
    private void Start()
    {
        //将方法组分配给委托时，编译器会执行方法组转换。并且这个过程会允许对输入参数进行逆变匹配
        TargetHandler<Player> playerHandler = LogTarget;
        TargetHandler<Player> playerHandler2 = new TargetHandler<Player>(LogTarget);
        
        SelectTarget<Boss> selectBoss = () => new GameObject("Boss").AddComponent<Boss>();
        SelectTarget<Enemy> selectEnemy = selectBoss;
        Enemy e = selectEnemy();
    }

    private void LogTarget(Target t)
    {
        Debug.Log($"Target: {t.name}");
    }
}

public class Target : MonoBehaviour
{
    
}

public partial class Player : Target
{
    
}