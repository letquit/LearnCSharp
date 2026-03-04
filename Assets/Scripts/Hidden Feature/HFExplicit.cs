using UnityEngine;

public class HFExplicit : MonoBehaviour
{
    ILogger logger = new UnityLogger();

    private void Start()
    {
        logger.Log("Hello from Start");

        Health hp = (Health)100;    // Must cast explicitly
        int intHp = (int)hp;    // Must cast explicitly

        hp = 100;   // Implicit conversion from int to Health
        intHp = hp;   // Implicit conversion from int to Health
        
        ApplyDamage(hp);
        ApplyDamage(intHp);
        // ApplyDamage((Health)100);
    }

    private void ApplyDamage(Health hp)
    {
        logger.LogInfo($"Applying damage: {hp.value}");
    }

}
