using System;
using UnityEngine;

public class SingletonPattern : MonoBehaviour
{
    private void Start()
    {
        // new GameManager();
        Debug.Log(GameManager.Instance);
        GameManager.Instance.TestFunction();
    }

    // private class Player
    // {
    //     public void AddSource()
    //     {
    //         GameManager.Instance.AddSource();
    //     }
    // }

    public class GameManager
    {
        private static GameManager instance;

        public static GameManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new GameManager();
                return instance;
            }
            // private set
            // {
            //     instance = value;
            // }
        }

        private GameManager()
        {
            
        }
        // public GameManager()
        // {
        //     if (instance == null)
        //     {
        //         instance = this;
        //     }
        // }

        public void TestFunction()
        {
            // ...
        }
    }
}
