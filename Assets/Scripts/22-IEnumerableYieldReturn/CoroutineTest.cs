using System;
using System.Collections;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(MyCoroutine());
    }

    private IEnumerator MyCoroutine()
    {
        Debug.Log("Before");
        yield return new WaitForSeconds(3);
        Debug.Log("After time");
    }
}
