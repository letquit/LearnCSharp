using System;
using System.Reflection;
using UnityEngine;

public class Reflection : MonoBehaviour
{
    private void Start()
    {
        // Debug.Log(typeof(Reflection).Assembly);
        foreach (Type type in typeof(Reflection).Assembly.GetTypes())
        {
            Debug.Log(type);
        }
        Debug.Log("");
        Debug.Log(typeof(Reflection).Assembly.GetType("Reflection+Exercise+Player"));
        
        // Exercise exercise = new Exercise();
        // // exercise.MyFunction();
        //
        // // MethodInfo myFunctionMethodInfo = typeof(Exercise).GetMethod("MyFunction");
        // // if (myFunctionMethodInfo != null) myFunctionMethodInfo.Invoke(exercise, new object[] { });
        //
        // Exercise exercise1 = new Exercise();
        // // if (typeof(Exercise.Player) != null)
        // // {
        // //     
        // // }
        // Type playerType = typeof(Exercise).GetNestedType("Player");
        // Debug.Log(playerType);
        //
        // // foreach (Type type in typeof(Exercise).GetNestedTypes())
        // foreach (Type type in typeof(Exercise).GetNestedTypes(BindingFlags.NonPublic | BindingFlags.Static))
        // {
        //     Debug.Log(type);
        // }
        
        Exercise exercise = new Exercise();
        Type playerType = typeof(Exercise).GetNestedType("Player");
        Debug.Log(playerType);

        object playerObject = Activator.CreateInstance(playerType);
        // Exercise.Player player = new Exercise.Player();
        MethodInfo myFunctionMethodInfo = playerType.GetMethod("MyFunction", BindingFlags.NonPublic | BindingFlags.Instance);
        // myFunctionMethodInfo.Invoke(new Exercise.Player(), new object[] { 56 });
        // myFunctionMethodInfo.Invoke(new Exercise.Player(), new object[] { false });
        myFunctionMethodInfo.Invoke(playerObject, new object[] { 56 });
        
        // myFunctionMethodInfo.ReturnType
        // myFunctionMethodInfo.GetParameters()
        
        // Exercise.Player player = new Exercise.Player();
        // player.MyFunction(5);
    }

    public class Exercise
    {
        // public void MyFunction(int i)
        // {
        //     Debug.Log("MyFunction " + i);
        // }

        public class Player
        {
            // public void MyFunction(int i)
            private void MyFunction(int i)
            {
                Debug.Log("MyFunction " + i);
            }
        }
        // private class Unit
        // {
        // }
        // private class Enemy
        // {
        // }
    }
}
