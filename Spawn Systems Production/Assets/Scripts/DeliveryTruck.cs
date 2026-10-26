using UnityEngine;

public class DeliveryTruck : MonoBehaviour, IVehicle
{
    public void Drive()
    {
        Debug.Log("Time to change 8 lanes. Good Luck Everyone else.");
    }
}
