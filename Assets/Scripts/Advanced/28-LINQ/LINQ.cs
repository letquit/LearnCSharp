using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Xml.Linq;

public class LINQ : MonoBehaviour
{
    private void Start()
    {
        List<Player> playerList = new List<Player>
        {
            new Player { playerName = "Code Monkey", team = "Red" },
            new Player { playerName = "Iron Man", team = "Blue" },
            new Player { playerName = "Black Window", team = "Red" },
            new Player { playerName = "Captain America", team = "Blue" },
        };
        List<Player> redPlayerList = playerList.Where(player => player.team == "Red").ToList();
        // List<Player> redPlayerList = playerList.Where(player => player.team == "Red").All();
        // List<Player> redPlayerList = playerList.Where(player => player.team == "Red").Any();
        // List<Player> redPlayerList = playerList.Where(player => player.team == "Red").First();
        // List<Player> redPlayerList = playerList.Where(player => player.team == "Red").Intersect();
        // List<Player> redPlayerList = playerList.Where(player => player.team == "Red").Join();
        // List<Player> redPlayerList = playerList.Where(player => player.team == "Red").Last();
        
        IEnumerable<Player> redPlayerIEnumerable = 
            from player in playerList
            where player.team == "Red"
            select player;
        // SELECT * FROM playerList WHERE team = "Red"
        
        foreach (Player player in redPlayerList)
        {
            Debug.Log(player);
        }
        
        foreach (Player player in redPlayerIEnumerable)
        {
            Debug.Log(player);
        }
        
        XElement contancts = XElement.Load(@"c:\myContactList.xml");
        var data =
            from contact in contancts.Elements("Record")
            from field in contact.Elements("Field")
            where field.Value == "Code Monkey"
            select contact;
    }
    
    private class Player
    {
        public string playerName;
        public string team;

        public override string ToString()
        {
            return playerName + ", " + team;
        }
    }
}
