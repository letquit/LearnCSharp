using System;
using UnityEngine;

public class ClassIndexer : MonoBehaviour
{
    private void Start()
    {
        PlayerStats playerStats = new PlayerStats
        {
            strAmount = 12,
            dexAmount = 36,
            wisAmount = 56
        };
        
        int strength = playerStats[0];
        Debug.Log(strength);
        playerStats[0] = 99;
        Debug.Log(playerStats[0]);
        
        playerStats[PlayerStats.Stat.Str] = 12;
        int strength1 = playerStats[PlayerStats.Stat.Str];
        Debug.Log(strength1);
        playerStats[PlayerStats.Stat.Str] = 99;
        Debug.Log(playerStats[PlayerStats.Stat.Str]);
    }

    public class PlayerStats
    {
        public enum Stat
        {
            Str,
            Dex,
            Wis
        }

        public int strAmount;
        public int dexAmount;
        public int wisAmount;

        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return strAmount;
                    case 1:
                        return dexAmount;
                    case 2:
                        return wisAmount;
                    default:
                        // return new IndexOutOfRangeException();
                        return 0;
                }
            }

            set
            {
                switch (index)
                {
                    case 0:
                        strAmount = value;
                        break;
                    case 1:
                        dexAmount = value;
                        break;
                    case 2:
                        wisAmount = value;
                        break;
                }
            }
        }
        
        public int this[Stat stat]
        {
            get
            {
                switch (stat)
                {
                    case Stat.Str:
                        return strAmount;
                    case Stat.Dex:
                        return dexAmount;
                    case Stat.Wis:
                        return wisAmount;
                    default:
                        // return new IndexOutOfRangeException();
                        return 0;
                }
            }

            set
            {
                switch (stat)
                {
                    case Stat.Str:
                        strAmount = value;
                        break;
                    case Stat.Dex:
                        dexAmount = value;
                        break;
                    case Stat.Wis:
                        wisAmount = value;
                        break;
                }
            }
        }
        
        public int this[Stat stat, int index]
        {
            get
            {
                switch (stat)
                {
                    case Stat.Str:
                        return strAmount;
                    case Stat.Dex:
                        return dexAmount;
                    case Stat.Wis:
                        return wisAmount;
                    default:
                        // return new IndexOutOfRangeException();
                        return 0;
                }
            }

            set
            {
                switch (stat)
                {
                    case Stat.Str:
                        strAmount = value;
                        break;
                    case Stat.Dex:
                        dexAmount = value;
                        break;
                    case Stat.Wis:
                        wisAmount = value;
                        break;
                }
            }
        }
    }
}
