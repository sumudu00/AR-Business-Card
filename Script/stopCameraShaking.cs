using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopCameraShaking : MonoBehaviour
{
    public float smoothSpeed = 0.1f;
    private Vector3 targetPosition;
    private Quaternion targetRotation;

    void Update()
    {
        if (Camera.main != null)
        {
            targetPosition = Camera.main.transform.position;
            targetRotation = Camera.main.transform.rotation;

            // Smoothly interpolate the camera's position and rotation
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, smoothSpeed);
        }
    }
}
