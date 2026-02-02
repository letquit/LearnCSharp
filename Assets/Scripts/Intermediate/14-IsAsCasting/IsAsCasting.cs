using UnityEngine;

public class IsAsCasting : MonoBehaviour
{
    private void Start()
    {
        // IAttackable attackable = new Player();
        IAttackable attackable = new Enemy();
        // // IAttackable attackable2 = new Enemy();
        //
        // // attackable.PlayerSayHello();
        // Debug.Log(attackable.GetType());
        // if (attackable is Player)
        // // if (attackable.GetType() == typeof(Player))
        // // if (attackable.GetType() == typeof(IAttackable))
        // // if (new Player() is IAttackable)
        // {
        //     Debug.Log("Is Player!");
        //     // Player player = attackable as Player;
        //     Player player = (Player)attackable;
        //     player.PlayerSayHello();
        //     // attackable.PlayerSayHello();
        // }
        //
        // // AttackObject(new Player());
        // // AttackObject(new Enemy());
        
        // Player player = new Player();
        // Enemy enemy = new Enemy();
        //
        // // Player testPlayer = (Player)enemy;
        // // 使用强制转换会失败并抛出异常 使用as转换会返回null
        // // Player testPlayer = (Player)attackable;
        // Player testPlayer = attackable as Player;
        // Debug.Log(testPlayer);
        
        // int a = 5;
        // // as 运算符必须与引用或可以为 null 的类型一起使用('float' 是不可以为 null 的值类型)
        // // float f = a as float;
        // float f = (float)a;
        
        int a = 5;
        object obj = a;
        int b = (int)obj;
    }

    private void AttackObject(IAttackable attackable)
    {
        attackable.Damage();
    }

    public class Player : Unit, IAttackable, IMovable, IHasInventory
    {
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
