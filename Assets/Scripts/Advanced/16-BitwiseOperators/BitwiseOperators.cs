using UnityEngine;

public class BitwiseOperators : MonoBehaviour
{
    public LayerMask layerMask;
    
    private void Start()
    {
        int a = 2;
        int b = 3;
        int c = 5;
        
        Debug.Log(a & b);
        Debug.Log(c | b);
        Debug.Log(c ^ b);
        Debug.Log(~c);
        
        Debug.Log(1 << 2);
        Debug.Log(8 >> 2);

        int unitsLayer = 6;
        int buildingsLayer = 9;
        int layerMask = 1 << unitsLayer | 1 << buildingsLayer;
        // Physics.Raycast();
    }   
}
