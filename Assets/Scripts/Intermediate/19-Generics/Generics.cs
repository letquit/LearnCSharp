using UnityEngine;

public class Generics : MonoBehaviour
{
    private void Start()
    {
        // MyList<int> myIntList = new MyList<int>();
        // myIntList.field = 5;
        // Debug.Log(myIntList.MyFunction());
        //
        // MyList<bool> myBoolList = new MyList<bool>();
        // myBoolList.field = false;
        // Debug.Log(myBoolList.MyFunction());
        //
        // TestFunction(false);
        
        // MyList<Player> myIntList = new MyList<Player>();
        // myIntList.field = new Player();
        // Debug.Log(myIntList.MyFunction());
        
        Inventory<Gold> goldInventory = new Inventory<Gold>();
        Inventory<Wood> woodInventory = new Inventory<Wood>();
        
        // goldInventory.Add(new Wood());
        goldInventory.Add(new Gold());
    }
    
    private class Gold {}
    
    private class Wood {}

    private class Inventory<T>
    {
        public void Add(T t)
        {
            
        }
    }

    private void GetAttackWinner<TAttackable, TDefendable>(TAttackable attackable, TDefendable defendable)
        where TAttackable : IAttackable where TDefendable : IDefendable
    {
        attackable.GetAttackPoints();
        defendable.GetDefendPoints();
    }
    
    private interface IAttackable
    {
        public int GetAttackPoints();
    }
    
    private interface IDefendable
    {
        public int GetDefendPoints();
    }
    
    private void MyFunction<T>(T t) where T : class
    {
        
    }

    private class Player
    {
        
    }

    // private T TestFunction<T>(T p)
    private void TestFunction<T>(T p)
    {
        Debug.Log(p);
    }

    // private class MyList<T>
    // private struct MyList<T>
    // private class MyList<T> where T : class
    private class MyList<T> where T : class, new()
    {
        public T field;

        public T MyFunction()
        {
            // new T();
            // return null;
            // return default;
            return new T();
        }
    }
    
    private interface IMyInterface<T>
    {
        T MyFunction();
    }
}
