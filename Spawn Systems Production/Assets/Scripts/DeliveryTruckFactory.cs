using UnityEngine;

[CreateAssetMenu(fileName = "DeliveryTruckFactory", menuName = "Scriptable Objects/DeliveryTruckFactory")]
public class DeliveryTruckFactory : ScriptableObject, IVehicleFactory
{
    [SerializeField] private GameObject deliveryTruckPrefab;

    public IVehicle Create(VehicleRequirements requirements, Vector3 position)
    {
        GameObject prefabToSpawn = deliveryTruckPrefab;
        
        if (requirements.NumberOfWheels == 2)
        {
            prefabToSpawn = deliveryTruckPrefab;
        }

        GameObject instance = Instantiate(prefabToSpawn, position, Quaternion.identity);
        return instance.GetComponent<IVehicle>();
    }
}
