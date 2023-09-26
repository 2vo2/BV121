using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class WinChecker : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.TryGetComponent(out Player car))
        {
            print("Player WIN");
        }
        if (collider.gameObject.TryGetComponent(out Bot bot))
        {
            print("Bot WIN");
        }
    }
}
