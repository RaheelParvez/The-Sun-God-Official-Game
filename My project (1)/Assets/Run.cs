using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour

{
   
     public Transform target;
    public float rotationSpeed = 5f;
    public float movementSpeed = 5f;

    void Start ()
    {
        transform.rotation = Quaternion.identity;
    }

   void Update()
    {
        if (target != null)
        {
            // Calculate the direction to the target
            Vector3 directionToTarget = target.position - transform.position;

            // Calculate the rotation needed to face the target
            Quaternion targetRotation = Quaternion.LookRotation(-directionToTarget);  // Invert the direction

            // Smoothly interpolate the current rotation towards the target rotation
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // Move towards the target
            transform.position = Vector3.MoveTowards(transform.position, target.position, movementSpeed * Time.deltaTime);
        }
    }
}


