using System;
using UnityEngine;

public class Dynamic : MonoBehaviour
{
    private static string json =
        "{" +
        "  \"assets\": [" +
        "    {\"type\": \"texture\", \"name\": \"player\", \"path\": \"textures/player.png\" }," +
        "    {\"type\": \"sound\", \"name\": \"background\", \"path\": \"sounds/bg_music.mp3\" }," +
        "    {\"type\": \"model\", \"name\": \"enemy\", \"path\": \"models/enemy.obj\" }" +
        "  ]" +
        "}";

    public class Rootobject
    {
        public Asset[] assets { get; set; }
    }

    public class Asset
    {
        public string type { get; set; }
        public string name { get; set; }
        public string path { get; set; }
    }
    
    private void Start()
    {
        // dynamic d;
        // var v = 56;
        // dynamic d = new object();
        // d.Test();
        
        // object d = new object();
        // d.ToString();
        
        // dynamic jsonDynamic = JObject.Parse(json);
        // Debug.Log(jsonDynamic.GetType().GetProperties());
        // Debug.Log(jsonDynamic.assets[0].type);
        // try
        // {
        //     string typeName = jsonDynamic.asset[0].type;
        // }
        // catch (RuntimeBinderException)
        // {
        
        dynamic d = Test();
        // Debug.Log(d.name);
    }
        
    private dynamic Test()
    {
        return new  { name = "Code Monkey", health = 100 };
    }
}