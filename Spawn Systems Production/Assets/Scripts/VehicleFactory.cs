using UnityEngine;

public class VehicleFactory
{
    private readonly IVehicleFactory _subFactory;
    private readonly VehicleRequirements _requirements;

    public VehicleFactory(VehicleRequirements requirements, BicycleFactory bicycleFact, SportsCarFactory sportsCarFact, DeliveryTruckFactory deliveryTruckFact)
    {
        _requirements = requirements;

        if (requirements.NumberOfWheels == 2)
        {
            _subFactory = bicycleFact;
        }
        if (requirements.HasEngine)
        {
            _subFactory = sportsCarFact;
        }
        if (requirements.HasCargo)
        {
            _subFactory = deliveryTruckFact;
        }
    }

    public IVehicle Create(Vector3 spawnPosition)
    {
        return _subFactory.Create(_requirements, spawnPosition);
    }
}
