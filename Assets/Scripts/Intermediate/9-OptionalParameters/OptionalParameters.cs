using System;
using UnityEngine;

public class OptionalParameters : MonoBehaviour
{
    private const int DEFAULT_HEALTH_AMOUNT = 100;
    
    private enum UnitType
    {
        Melee,
        Ranged,
        Wizard
    }

    private void Start()
    {
        SpawnUnit(new Vector3(0, 0, 0), UnitType.Melee, Quaternion.identity, 56);
        SpawnUnit(new Vector3(10, 5, 0), UnitType.Ranged, Quaternion.identity);
        SpawnUnit();
        SpawnUnit(new Vector3(10, 1, 1), UnitType.Wizard);
        SpawnUnit(healthAmount: 56, unitType: UnitType.Ranged);
    }

    // private void SpawnUnit(Vector3 spawnPosition)
    // {
    //     SpawnUnit(spawnPosition, UnitType.Melee, Quaternion.identity, 100);
    // }
    
    private void SpawnUnit(
        Vector3 spawnPosition = default,
        // UnitType unitType,
        UnitType unitType = UnitType.Melee,
        Quaternion spawnRotation = default,
        int healthAmount = DEFAULT_HEALTH_AMOUNT)
    {
        Debug.Log($"Spawning unit of type {unitType} with health:{healthAmount} at {spawnPosition}, {spawnRotation}");
    }
}
