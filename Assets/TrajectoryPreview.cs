using UnityEngine;

public class TrajectoryPreview : MonoBehaviour
{
    public LineRenderer line;
    public Transform gazeOrigin;   // la Main Camera
    public Transform boule;        // boule à lancer
    public int resolution = 20;
    public float initialForce = 6f;
    public float step = 0.1f;

    void Update()
    {
        if (boule == null || line == null || gazeOrigin == null) return;

        line.enabled = true; // affichage permanent

        line.positionCount = resolution;

        Vector3 start = boule.position;
        Vector3 velocity = gazeOrigin.forward * initialForce;

        for (int i = 0; i < resolution; i++)
        {
            float t = i * step;
            Vector3 point = start + velocity * t + 0.5f * Physics.gravity * t * t;
            line.SetPosition(i, point);
        }
    }

    public Vector3 GetLaunchVelocity()
    {
        return gazeOrigin.forward * initialForce;
    }
}
