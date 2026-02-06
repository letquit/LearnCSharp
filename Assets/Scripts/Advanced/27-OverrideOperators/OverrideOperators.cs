using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using NUnit.Framework;
using UnityEngine;

public class OverrideOperators : MonoBehaviour
{
    private void Start()
    {
        ResourceAmount resourceAmount1 = new ResourceAmount
        {
            resourceType = ResourceType.Wood,
            amount = 5,
        };
        ResourceAmount resourceAmount2 = new ResourceAmount
        {
            resourceType = ResourceType.Wood,
            // amount = 12,
            amount = 5,
        };
        ResourceAmount resourceAmountTotal = resourceAmount1 + resourceAmount2;
        Debug.Log(resourceAmountTotal);

        Debug.Log(resourceAmount1 == resourceAmount2);
        Debug.Log(resourceAmount1.Equals(resourceAmount2));
        Debug.Log(resourceAmount1.GetHashCode() + " " + resourceAmount1.GetHashCode());

        List<ResourceAmount> resourceAmountList = new List<ResourceAmount>
        {
            new ResourceAmount
            {
                resourceType = ResourceType.Gold,
                amount = 12,
            }
        };
        Debug.Log(
            resourceAmountList.Contains(new ResourceAmount
            {
                resourceType = ResourceType.Gold,
                amount = 12,
            })
        );
    }

    public enum ResourceType
    {
        Wood,
        Gold
    }

    public class ResourceAmount : IEquatable<ResourceAmount>
    {
        public ResourceType resourceType;
        public int amount;

        public override string ToString()
        {
            return resourceType + ": " + amount;
        }

        public static ResourceAmount operator +(ResourceAmount resourceAmountA, ResourceAmount resourceAmountB)
        {
            if (resourceAmountA.resourceType != resourceAmountB.resourceType)
            {
                throw new Exception();
            }

            return new ResourceAmount
            {
                resourceType = resourceAmountA.resourceType,
                amount = resourceAmountA.amount + resourceAmountB.amount
            };
        }

        public static bool operator ==(ResourceAmount resourceAmountA, ResourceAmount resourceAmountB)
        {
            return resourceAmountA.resourceType == resourceAmountB.resourceType &&
                   resourceAmountA.amount == resourceAmountB.amount;
        }

        public static bool operator !=(ResourceAmount resourceAmountA, ResourceAmount resourceAmountB)
        {
            return !(resourceAmountA == resourceAmountB);
        }

        public override bool Equals([CanBeNull] object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            if (obj is ResourceAmount)
            {
                return this == (ResourceAmount)obj;
            }

            return false;
        }


        public bool Equals([CanBeNull] ResourceAmount other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }

            return this == other;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(resourceType, amount);
        }
    }
}