using System;
using System.Collections;
using UnityEngine;
using UnityRandom = UnityEngine.Random;

[System.Serializable]
public class CoroutineTest : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(MyCoroutine());
        
        // UnityEngine.Random.Range(0, 1);
        UnityRandom.Range(0, 1);
    }

    private IEnumerator MyCoroutine()
    {
        Debug.Log("Before");
        yield return new WaitForSeconds(3);
        Debug.Log("After time");
    }
}
