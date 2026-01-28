using System;
using Unity.VisualScripting;
using UnityEngine;

public class ValueReferenceTypes : MonoBehaviour
{
    private void Start()
    {
        // // Reference
        // // 引用类型（Reference Type）
        // //     存储方式：存储指向数据的地址（指针）
        // //     复制行为：复制时共享同一个数据
        // //     代表类型：class、array、string等
        // MyClass myClass = new MyClass();
        // myClass.a = 7;
        // MyClass mySecondClass = myClass;
        // mySecondClass.a = 5;
        //
        // Debug.Log("Class: " + myClass.a);
        //
        // // Value
        // // 值类型（Value Type）
        // //     存储方式：直接存储数据本身
        // //     复制行为：复制时创建全新的副本
        // //     代表类型：int、float、bool、struct等
        // int a = 7;
        // int b = a;
        // b = 5;
        //
        // Debug.Log("Value: " + a);
        //
        // // Struct
        // MyStruct myStruct = new MyStruct();
        // myStruct.a = 7;
        // MyStruct mySecondStruct = myStruct;
        // mySecondStruct.a = 5;
        //
        // Debug.Log("Struct: " + myStruct.a);
        
        // MyClass myClass = new MyClass();
        // myClass.a = 7;
        // MyStruct myStruct = new MyStruct();
        // myStruct.a = 7;
        //
        // MyFunction(myClass, myStruct);
        //
        // Debug.Log(myClass.a + " " + myStruct.a);
        
        int a = 7;
        int[] intArray = new int[] { 7 };
        MyFunction(a, intArray);
        
        Debug.Log(a + " " + intArray[0]);

        // int b = null;
        Nullable<int> b = null;
    }

    // private void MyFunction(MyClass myClass, MyStruct myStruct)
    private void MyFunction(int a, int[] intArray)
    {
        a = 5;
        intArray[0] = 5;
    }
    
    private class MyClass
    {
        public int a;
    }
    
    private struct MyStruct
    {
        public int a;
    }
}
