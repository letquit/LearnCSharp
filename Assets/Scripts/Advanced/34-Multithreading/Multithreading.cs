using System;
using System.Threading;
using UnityEngine;
using Object = UnityEngine.Object;

public class Multithreading : MonoBehaviour
{
    private static int resourceAmount;
    private static object resourceLock = new object();
    
    private void Start()
    {
        // DeadlockExample();
        // return;
        
        // for (int i = 0; i < 10; i++)
        // {
        //     Debug.Log("Start thread work... " + i);
        //     Thread.Sleep(500);
        // }
        // for (int i = 0; i < 10; i++)
        // {
        //     Debug.Log("Calculating pathfinding... " + i);
        //     Thread.Sleep(600);
        // }
        // return;

        for (int i = 0; i < 10; i++)
        {
            ThreadPool.QueueUserWorkItem(DoWork);
        }

        while (true) { }
        return;
        
        Thread[] threadArray = new Thread[10];
        for (int i = 0; i < threadArray.Length; i++)
        {
            threadArray[i] = new Thread(AddResources);
        }
        for (int i = 0; i < threadArray.Length; i++)
        {
            threadArray[i].Start();
        }
        for (int i = 0; i < threadArray.Length; i++)
        {
            threadArray[i].Join();
        }
        Debug.Log("resourceAmount: " + resourceAmount);
        return;
        
        Thread workerThread = new Thread(new ThreadStart(CalculatePathfinding));
        
        workerThread.Start();

        for (int i = 0; i < 10; i++)
        {
            Debug.Log("Start thread work... " + i);
            Thread.Sleep(500);
        }
        
        workerThread.Join();
        
        Debug.Log("Start thread done");
    }

    private static void DoWork(object obj)
    {
        Debug.Log(Thread.CurrentThread.ManagedThreadId + " started");
        Thread.Sleep(500);
        Debug.Log(Thread.CurrentThread.ManagedThreadId + " finished");
    }
    
    private static void CalculatePathfinding()
    {
        Debug.Log("Calculating pathfinding...");
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("Calculating pathfinding..." + i);
            Thread.Sleep(600);
        }
        // Thread.Sleep(3000);
        Debug.Log("Pathfinding done!");
    }

    private static void AddResources()
    {
        for (int i = 0; i < 10000; i++)
        {
            lock (resourceLock)
            {
                int tmpResourceAmount = resourceAmount;
                tmpResourceAmount++;
                resourceAmount = tmpResourceAmount;
            }
        }
    }

    public static void DeadlockExample()
    {
        object lock1 = new object();
        object lock2 = new object();

        Thread thread1 = new Thread(() =>
        {
            lock (lock1)
            {
                Thread.Sleep(100);
                lock (lock2)
                {
                    Debug.Log("Thread 1 got both locks");
                }
            }
        });
        
        Thread thread2 = new Thread(() =>
        {
            lock (lock2)
            {
                Thread.Sleep(100);
                lock (lock1)
                {
                    Debug.Log("Thread 2 got both locks");
                }
            }
        });
        
        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();
    }
}
