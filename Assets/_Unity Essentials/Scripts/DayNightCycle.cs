using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // The duration of a day in seconds, editable in the Inspector
    [SerializeField] private float dayDuration = 86400f; // Default to 86400 seconds (24 hours)

    // Update is called once per frame
    void Update()
    {
        // Calculate the rotation speed based on the day duration
        float rotationSpeed = 360f / dayDuration * Time.deltaTime;

        // Rotate the light around the X-axis
        transform.Rotate(Vector3.right * rotationSpeed);
    }
}
