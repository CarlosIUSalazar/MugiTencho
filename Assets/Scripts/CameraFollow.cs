using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // Reference to Mugi's transform
    public float height = 3.66f;  // Height above Mugi
    public float distance = 6.35f;  // Distance behind Mugi
    public float followSpeed = 5f;  // Speed of camera adjustment

    void LateUpdate()
    {
        if (target != null)
        {
            // Calculate offset based on Mugi's rotation
            Vector3 offset = target.rotation * new Vector3(0, height, -distance);

            // Target position for the camera (behind and above Mugi)
            Vector3 targetPosition = target.position + offset;

            // Smoothly move the camera to the target position
            transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);

            // Make the camera look at Mugi
            transform.LookAt(target.position + Vector3.up * 1.5f);  // Adjust the vertical focus if needed
        }
    }
}
