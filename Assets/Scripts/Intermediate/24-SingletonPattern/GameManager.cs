using System;
using UnityEngine;

namespace CSharpCourse
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        private void Awake()
        {
            if (Instance != null)
            {
                Debug.LogError("Instance already exists!");
                Destroy(gameObject);
                return;
            }
            Instance = this;
        }
    }
}