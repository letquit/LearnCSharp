using System;
using UnityEngine;

public class RefOutIn : MonoBehaviour
{
    public enum State
    {
        Idle,
        Patrolling,
        Attacking
    }
    
    private void Start()
    {
        Unit unit = new Unit();
        // State state = unit.GetUnitState();
        int healthAmount;
        State state = unit.GetUnitState(out healthAmount);
        Debug.Log(healthAmount);
        
        int healthAmount1 = 0;
        State state1 = unit.GetUnitState(healthAmount1);
        Debug.Log(healthAmount1);

        unit.GetUnitData(out State state2, out int healthAmount2, out string name2);
        Debug.Log(state2 + " " + healthAmount2 + " " + name2);

        State state3 = State.Idle;
        // State state3;
        unit.GetUnitData3(ref state3, out int healthAmount3, out string name3);
        Debug.Log(state3 + " " + healthAmount3 + " " + name3);
        unit.GetUnitData3(ref state3, out int _, out string name4);
        unit.GetUnitData4(ref state3, in healthAmount1, out string name5);
    }

    public class Unit
    {
        public void Heal(ref int healthAmount, int healAmount)
        // public void Heal(int healthAmount, int healAmount)
        {
            healthAmount += healAmount;
        }

        public State GetUnitState()
        {
            return State.Idle;
        }
        
        public State GetUnitState(int healthAmount)
        {
            healthAmount = 56;
            return State.Idle;
        }
        
        public State GetUnitState(out int healthAmount)
        {
            healthAmount = 56;
            return State.Idle;
        }

        public void GetUnitData(out State state, out int healthAmount, out string name)
        {
            state = State.Idle;
            healthAmount = 56;
            name = "Code Monkey";
        }
        
        public void GetUnitData3(ref State state, out int healthAmount, out string name)
        {
            name = "Code Monkey";
            bool b = true;
            if (b)
            {
                state = State.Idle;
                healthAmount = 56;
                return;
            }
            else
            {
                healthAmount = 56;
                return;
            }
        }
        
        public struct HugeStruct
        {
            
        }

        // public void DoSomething(HugeStruct hugeStruct)
        public void DoSomething(in HugeStruct hugeStruct)
        {
            hugeStruct.ToString();
            // hugeStruct = new HugeStruct();
        }
        
        public void GetUnitData4(ref State state, in int healthAmount, out string name)
        {
            name = "Code Monkey";
            bool b = true;
            if (b)
            {
                state = State.Idle;
                // healthAmount = 56;
                Debug.Log(healthAmount);
                return;
            }
            else
            {
                // healthAmount = 56;
                return;
            }
        }
        
        public UnitData GetUnitData()
        {
            return new UnitData
            {
                state = State.Idle,
                healthAmount = 56,
                name = "Code Monkey"
            };
        }

        public class UnitData
        {
            public State state;
            public int healthAmount;
            public string name;
        }
    }
}
