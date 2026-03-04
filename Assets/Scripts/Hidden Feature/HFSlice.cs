using System;
using UnityEngine;

public class HFSlice : MonoBehaviour
{
    ILogger logger = new UnityLogger();

    private void Start()
    {
        logger.Log("Hello from Start");
        
        int[] scores = { 10, 20, 30, 40, 50 };
        
        int last = scores[^1];
        int[] last3 = scores[^3..]; // last 3
        int[] first2 = scores[..2]; // first 2
        int[] mid = scores[1..4];   // 20, 30, 40
    }
}
