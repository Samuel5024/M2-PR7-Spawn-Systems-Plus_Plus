using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{
    [SerializeField] private BicycleFactory bicycleFactoryAsset;
    [SerializeField] private SportsCarFactory sportsCarFactoryAsset;
    [SerializeField] private DeliveryTruckFactory deliverTruckFactoryAsset;
    [SerializeField] private VehicleRequirements currentRequirements; 
    [SerializeField] private Transform spawnPoint;

    public void BuildAndSpawnVehicle()
    {
        VehicleFactory factory = new VehicleFactory(currentRequirements, bicycleFactoryAsset, sportsCarFactoryAsset, deliverTruckFactoryAsset);
        IVehicle vehicle = factory.Create(spawnPoint.position);
        vehicle.Drive();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BuildAndSpawnVehicle();
        }
    }
}
