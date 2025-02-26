using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Duration of a full day in seconds")]
    public float dayDuration = 60f; // Default: 60 seconds for a full cycle

    private float rotationSpeed;

    void Start()
    {
        // Calculate rotation speed (360 degrees per full day duration)
        rotationSpeed = 360f / dayDuration;
    }

    void Update()
    {
        // Rotate the directional light around the X-axis
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}