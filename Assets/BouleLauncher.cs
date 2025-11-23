using UnityEngine;

public class BouleLauncher : MonoBehaviour
{
    public TrajectoryPreview trajectory; // référence au script de trajectoire
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Launch()
    {
        if (rb == null || trajectory == null) return;

        rb.isKinematic = false; // activer la physique
        rb.linearVelocity = trajectory.GetLaunchVelocity();
    }
}
