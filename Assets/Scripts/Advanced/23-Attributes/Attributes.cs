using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Attributes
{
    [Serializable]
    public class Attributes : MonoBehaviour
    {

        [SerializeField] private float moveSpeed;
    
        // [Obsolete]
        // [DllImport()]
        
        // [IsObjectType(ObjectType.Unit)]
        private void Start()
        {
            object[] attributeObjectArray = typeof(Player).GetCustomAttributes(typeof(IsObjectTypeAttribute), false);
            IsObjectTypeAttribute isObjectTypeAttribute = (IsObjectTypeAttribute)attributeObjectArray[0];
            Debug.Log(isObjectTypeAttribute.GetObjectType());
        }
    }

    [IsObjectType(ObjectType.Unit)]
    public class Player
    {
    
    }

    public enum ObjectType
    {
        Unit,
        Object,
        Prop
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class IsObjectTypeAttribute : System.Attribute
    {
        private ObjectType objectType;
    
        public IsObjectTypeAttribute(ObjectType objectType)
        {
            this.objectType = objectType;
        }
        
        public ObjectType GetObjectType()
        {
            return objectType;
        }
    }
}
