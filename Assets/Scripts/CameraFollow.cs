using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform carTransform; // The car's transform
    public Vector3 offset; // The offset from the car to the camera
    public float smoothSpeed = 0.125f; // How smooth the camera movement is

    void Start()
    {
        // Optionally, set the initial offset if you haven't already
        offset = transform.position - carTransform.position;
    }

    void LateUpdate()
    {
        // // Calculate the desired position of the camera
        // Vector3 desiredPosition = carTransform.position + offset;

        // // Smoothly move the camera to the desired position
        // Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        
        // // Set the camera position
        // transform.position = smoothedPosition;

        // // Optionally, make the camera always look at the car
        // transform.LookAt(carTransform.position + Vector3.up);

        // Apply the car's rotation to the offset to keep the camera behind the car
        // Vector3 desiredPosition = carTransform.position + carTransform.rotation * offset;
        Vector3 desiredPosition = carTransform.position - carTransform.forward * offset.z + Vector3.up * offset.y;

        // Smoothly move the camera to the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Set the camera position
        transform.position = smoothedPosition;

        // Calculate the direction to look from behind the car
        Vector3 directionToCar = carTransform.position - transform.position;

        // Make sure the camera looks at the car from behind (invert the direction)
        Quaternion targetRotation = Quaternion.LookRotation(directionToCar, Vector3.up);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, smoothSpeed);
    }
}
