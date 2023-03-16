using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
   public Transform targetObject;
   public float distance = 5.0f; // controls the distance between the camera and the player
   public float height = 2.0f; // controls the height of the camera above the player
   public float smoothFactor=0.5f;
   public bool lookAtTarget=true;

   void LateUpdate()
   {
        // Calculate the desired position of the camera based on the player's position, distance, and height
        UnityEngine.Vector3 desiredPosition = targetObject.position - targetObject.forward * distance + UnityEngine.Vector3.up * height;

        // Smoothly move the camera towards the desired position
        transform.position = UnityEngine.Vector3.Slerp(transform.position, desiredPosition, smoothFactor);

        // Always face the player
        if (lookAtTarget) {
            transform.LookAt(targetObject);
        }
   }
}

