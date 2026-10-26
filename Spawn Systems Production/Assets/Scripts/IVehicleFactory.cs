using UnityEngine;

public interface IVehicleFactory
{
    IVehicle Create(VehicleRequirements requirements, Vector3 position);
}
