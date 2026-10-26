using UnityEngine;

[CreateAssetMenu(fileName = "BicycleFactory", menuName = "Scriptable Objects/BicycleFactory")]
public class BicycleFactory : ScriptableObject, IVehicleFactory
{
    [SerializeField] private GameObject bicyclePrefab;

    public IVehicle Create(VehicleRequirements requirements, Vector3 position)
    {
        GameObject prefabToSpawn = bicyclePrefab;

        if (requirements.NumberOfWheels == 2)
        {
            prefabToSpawn = bicyclePrefab;
        }

        GameObject instance = Instantiate(prefabToSpawn, position, Quaternion.identity);
        return instance.GetComponent<IVehicle>();
    }
}
