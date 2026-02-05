using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class DataBoxing : MonoBehaviour
{
    private event EventHandler OnSomethingHappened;
    
    private void Start()
    {
        int i = 56;
        object o = i;
        i = (int)o;
        // bool b = (bool)o;
        
        List<object> objectList = new List<object>
        {
            12,
            false,
            "Code Monkey",
        };
        
        OnSomethingHappened += DataBoxing_OnSomethingHappened;
    }
    
    private void DataBoxing_OnSomethingHappened(object sender, EventArgs e)
    {
        
    }
}
