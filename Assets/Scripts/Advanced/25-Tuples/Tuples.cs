using System;
using UnityEngine;

public class Tuples : MonoBehaviour
{
    private void Start()
    {
        // var myTuple = (name: "Code Monkey", Value: 56);
        // Debug.Log(myTuple);
        // myTuple.Item1 = "Iron Man";
        // string playerName = "Code Monkey";
        // int value = 56;
        // var myTuple = (playerName, value);
        // myTuple.playerName = "Iron Man";
        (string playerName, int value) myTuple = ("Code Monkey", 56);
        // System.Tuple // System.Tuple类似匿名类型，不可变
        Debug.Log(myTuple.GetType());
        myTuple.playerName = "Iron Man";
        
        // var bigTuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20);
        // Debug.Log(bigTuple.Item20);
        
        var tuple = GetTuple();
        Debug.Log(tuple);

        // (string playerName, int value) = tuple;
        var (playerName, value) = tuple;
        Debug.Log(playerName);
        // string playerName = tuple.playerName;
        // int value = tuple.value;
        
    }

    // private (string name, int value) GetTuple((bool b, float f) tuple)
    private (string name, int value) GetTuple()
    {
        return ("Iron Man", 32);
    }
}
