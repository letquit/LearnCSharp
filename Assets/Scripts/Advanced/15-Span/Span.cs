using System;
using UnityEngine;

public class Span : MonoBehaviour
{
    private void Start()
    {
        int[] numberArray = new int[] { 5, 2, 12, 45, 0, 48, 99, 10 };
        // int[] subArray = new int[numberArray.Length - 2];
        // Span<int> intSpawn = numberArray;
        Span<int> intSpawn = new Span<int>(numberArray, 1, 6);
        // intSpawn.Sort();
        // Array.Sort(numberArray, 1, 6);
         intSpawn.Fill(56);

         // ReadOnlySpan<>
        foreach (int number in numberArray)
        {
            Debug.Log(number);
        }

        string str = "56,12";
        // str.Substring()
        ReadOnlySpan<char> charSpan = str;
        int number1 = int.Parse(charSpan.Slice(0, 2));
        int number2 = int.Parse(charSpan.Slice(3, 2));
        Debug.Log(number1 + " " + number2);
    }
}
