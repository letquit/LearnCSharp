using System;
using System.Collections.Generic;
using UnityEngine;

public class Dictionary : MonoBehaviour
{
    public enum ResourceType
    {
        Stone,
        Wood,
        Gold
    }

    [SerializeField] private Dictionary<ResourceType, int> resourceTypeAmountDictionary;


    [Serializable]
    public class ResourceTypeAmount
    {
        public ResourceType resourceType;
        public int amount;
    }
    
    [SerializeField] private List<ResourceTypeAmount> resourceTypeAmountList;

    private void Awake()
    {
        resourceTypeAmountDictionary = new Dictionary<ResourceType, int>();

        foreach (ResourceTypeAmount resourceTypeAmount in resourceTypeAmountList)
        {
            resourceTypeAmountDictionary[resourceTypeAmount.resourceType] = resourceTypeAmount.amount;
        }
        
        Debug.Log("Dictionary:");
        foreach (ResourceType resourceType in resourceTypeAmountDictionary.Keys)
        {
            Debug.Log(resourceType + ": " + resourceTypeAmountDictionary[resourceType]);
        }
    }

    private void Start()
    {
        // Dictionary<ResourceType, int> resourceTypeAmountDictionary = new Dictionary<ResourceType, int>()
        // {
        //     { ResourceType.Stone, 10 },
        //     { ResourceType.Wood, 35 },
        // };
        //
        // foreach (ResourceType resourceType in resourceTypeAmountDictionary.Keys)
        // {
        //     Debug.Log(resourceType + ": " + resourceTypeAmountDictionary[resourceType]);
        // }
        
        // foreach (KeyValuePair<ResourceType, int> keyValuePair in resourceTypeAmountDictionary)
        // {
        //     Debug.Log(keyValuePair.Key + ": " + keyValuePair.Value);
        // }
        
        // resourceTypeAmountDictionary.Add(ResourceType.Stone, 56);
        // // resourceTypeAmountDictionary.Add(ResourceType.Stone, 30);
        // // resourceTypeAmountDictionary[ResourceType.Stone] = 30;
        // // Debug.Log(resourceTypeAmountDictionary[ResourceType.Stone]);
        // // resourceTypeAmountDictionary.ContainsKey(ResourceType.Wood);
        // resourceTypeAmountDictionary[ResourceType.Wood] = 30;
        // resourceTypeAmountDictionary.Remove(ResourceType.Wood);
        // if (resourceTypeAmountDictionary.TryGetValue(ResourceType.Wood, out int woodAmount))
        // {
        //     Debug.Log(woodAmount);
        // }
        // // Debug.Log(resourceTypeAmountDictionary[ResourceType.Wood]);
    }
}
