using System;
using UnityEngine;

public class LocalFunctionLambda : MonoBehaviour
{
    public void Start()
    {
        Print("Message");

        // myAction();
        
        Action<string> myAction = (string message) =>
        {
            Debug.Log(message);
        };

        int age;

        void Print(string message)
        {
            Debug.Log(message);
        }

        Action<string> myAction2 = Print;
    }

    // private void AnotherFunction()
    // {
    //     Print();
    // }
}
