using System;
using UnityEngine;

namespace CSharpCourse
{
    public class Namespaces : MonoBehaviour
    {
        private void Start()
        {
            Player player;
            CodeMonkey.Player player2;
        }
    }
    
    public class Player{}
    // public class Player{}
    
}

namespace CodeMonkey
{ 
    public class Player{}
}