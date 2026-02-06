using System;
using System.Linq;
using UnityEngine;

public class AnonymousTypes : MonoBehaviour
{
    private void Start()
    {
        // Player player = new Player
        // {
        //     playerName = "Code Monkey",
        //     id = 56
        // };

        var i = 56;
        // var playerData = new { Name = "Code Monkey", Id = 1 };
        // Debug.Log(playerData.GetType());
        // playerData.Name = "Iron Man";
        // Debug.Log(playerData.Name);
        // var playerData = new { Name = null, Id = 1 };
        var message = new { Message = "Hello World" };
        // var playerData = new { Name = new Player(), Id = 1, Message = message };
        // var playerData = new { Name = new Player(), Id = 1, message };
        var playerData = new { Name = "Code Monkey", Id = 1, message };
        // playerData.Message.Message
        // playerData.message
        // var playerData2 = playerData with { Name = "Iron Man" };
        var playerDataArray = new[]
        // var playerDataArray = new object[]
        {
            new { Name = "Code Monkey", Team = "Red" },
            new { Name = "Iron Man", Team = "Blue" },
            new { Name = "Captain America", Team = "Red" },
            new { Name = "Thor", Team = "Yellow" },
            // new { Team = "Yellow", Name = "Thor" },
        };

        var redTeamArray = playerDataArray.Where(playerData => playerData.Team == "Red")
            .Select(playerData => new { playerData.Name });
        
        foreach (var redTeam in redTeamArray)
        {
            Debug.Log(redTeam.Name);
        }
    }
    
    public class Player {}
    
    public class PlayerData
    {
        public string Name { get; }
        public int Id { get; }
    }
    
    // public class Player
    // {
    //     public string playerName;
    //     public int id;
    // }
}
