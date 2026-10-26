using UnityEngine;

[CreateAssetMenu(fileName = "SportsCarFactory", menuName = "Scriptable Objects/SportsCarFactory")]
public class SportsCarFactory : ScriptableObject
{
    [SerializeField] private GameObject sportsCarPrefab;

    public IVehicle Create(VehicleRequirements requirements, Vector3 position)
    {
        GameObject prefabToSpawn = sportsCarPrefab;
        
        if (requirements.HasEngine && requirements.Passengers >= 2)
        {
            prefabToSpawn = sportsCarPrefab;
        }

        GameObject instance = Instantiate(prefabToSpawn, position, Quaternion.identity);
        return instance.GetComponent<IVehicle>();
    }
}
