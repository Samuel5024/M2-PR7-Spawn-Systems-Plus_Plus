using UnityEngine;

public class Bicycle : MonoBehaviour, IVehicle
{
    public void Drive()
    {
        Debug.Log("Biking in the bus lane because, why not?");
    }
}
