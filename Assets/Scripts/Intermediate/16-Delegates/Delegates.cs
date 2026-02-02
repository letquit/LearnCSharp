
using System;
using System.Threading;
using UnityEngine;

public class Delegates : MonoBehaviour
{
    private delegate void AttackDelegate();

    private delegate int MyDelegate(string str);

    private AttackDelegate attackAction;

    private Action myAction;
    private Action<int> myAction1;
    // private delegate void myAction1(int i);
    private Func<int> myFunc;

    private void Start()
    {
        attackAction = MeleeAttack;
        // attackAction = RangedAttack;
        attackAction += RangedAttack;
        attackAction();
        Debug.Log("----");
        attackAction -= RangedAttack;
        attackAction();
        
        myAction = MeleeAttack;
        myAction1 = MyTestFunction2;
        
        myFunc = MyTestFunction3;
        
        MyDelegate myDelegate = MyTestFunction;
        
        //lambda
        Action myAction3 = () =>
        {
            Debug.Log("Melee Attack");
        };
        
        Action<int> myAction4 = (int i) =>
        {
            Debug.Log("Melee Attack");
        };
        
        // Func<int, bool> myFunc1 = (int i) =>
        // {
        //     return false;
        // };
        Func<int, bool> myFunc1 = (int i) => false;
        
        Unit unit = new Unit();
        unit.MoveTo(new Vector3(1, 2, 2), () =>
        {
            Debug.Log("Reached Target!");
        });
        
        unit.Update();
    }

    public class Unit
    {
        private Action OnReachedTarget;

        public void MoveTo(Vector3 targetPosition, Action onReachedTarget)
        {
            // Assign target
            this.OnReachedTarget = onReachedTarget;
        }

        public void Update()
        {
            // Move towards target
            Thread.Sleep(2000);
            OnReachedTarget();
        }
    }

    private void MeleeAttack()
    {
        Debug.Log("Melee Attack");
    }

    private void RangedAttack()
    {
        Debug.Log("Ranged Attack");
    }

    private int MyTestFunction(string myString)
    {
        return 0;
    }

    private void MyTestFunction2(int i)
    {
        
    }
    
    private int MyTestFunction3()
    {
        return 0;
    }
}
