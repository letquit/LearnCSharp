// #define TESTING
#define TESTING2

using System;
using UnityEngine;

// #pragma warning disable 0168
public class PreprocessorDirectives : MonoBehaviour
{
    #region FUNCTIONS
    private void Start()
    {
        bool testing = true;
        if (testing)
        {
            Debug.Log("Testing");
        }
        
#if TESTING
        Debug.Log("Testing");
#elif TESTING2
        Debug.Log("Testing 2");
#else
        Debug.Log("Not Testing");
#endif
      
#if DEBUG
        Debug.Log("Debugging");
#endif
        
#if RELEASE
        Debug.Log("Releasing");
#endif
      
#if NET6_0_OR_GREATER
        Debug.Log("Net 6.0 or greater");
#endif
        
#if !Net8_0
        Debug.Log("Net 8.0");
// #error Some error
#endif

#warning This is a warning
#pragma warning disable
        int i;
#pragma warning restore
        int b;
    }
    #endregion
}
