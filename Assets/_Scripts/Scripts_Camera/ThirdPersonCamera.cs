using System.Collections;
     using System.Collections.Generic;
     using UnityEngine;
 
     public class ThirdPersonCamera : MonoBehaviour
     {

         
         public bool lockCursor;
         public float mouseSensitivity = 10;
         public Transform target;
         public float dstFromTarget = 15;

         public float dstFromTargetMin = 15;
         public float dstFromTargetMax = 25;
 
         public float rotationSmoothTime = .12f;
         Vector3 rotationSmoothVelocity;
         Vector3 currentRotation;
 
         public float minPitch = -40;
         public float maxPitch = 85;
 
         public float yaw;
         public float pitch;
 
         Vector3 center = new Vector3(0f, 0.5f, 0f);
         RaycastHit hit;
         


         public void Start()
         {
             if (lockCursor)
             {
                 Cursor.lockState = CursorLockMode.Locked;
                 Cursor.visible = false;
             }
             
             
             
         }   
 
         void Update()
         {



             
             yaw += Input.GetAxis("Mouse X") * mouseSensitivity;
             pitch -= Input.GetAxis("Mouse Y") * mouseSensitivity;
             pitch = Mathf.Clamp(pitch, minPitch, maxPitch);
 
             currentRotation = Vector3.SmoothDamp(currentRotation, new Vector3(pitch, yaw), ref rotationSmoothVelocity, rotationSmoothTime);
             transform.eulerAngles = currentRotation;
 
            
             dstFromTarget = Mathf.Clamp(dstFromTarget - Input.GetAxis("Mouse ScrollWheel") * 5, dstFromTargetMin, dstFromTargetMax);
             Vector3 wantedCameraPosition = target.position + center - transform.forward * dstFromTarget;
             
 
             // Raycasting 
             Vector3 rayDirection = (wantedCameraPosition - (target.position + center)).normalized;
 
             if (Physics.Raycast(target.position + center, rayDirection, out hit, dstFromTarget)
                 && hit.transform != target.parent) // ignore ray-casts that hit the user. DR
             {
                 // Debug.Log(hit.transform.name  + " " + direction.ToString());
                 wantedCameraPosition.x = hit.point.x;
                 wantedCameraPosition.z = hit.point.z;
                 //wantedPosition.y = wantedPosition.y);
             }
 


             transform.position = wantedCameraPosition;

             if (GameObject.FindGameObjectWithTag("Pausa").activeInHierarchy) 
{
Cursor.lockState = CursorLockMode.None;
Cursor.visible = true;
}
if (GameObject.FindGameObjectWithTag("Pausa").activeInHierarchy == false)
{
    Cursor.lockState = CursorLockMode.Locked;
Cursor.visible = false;
}

             


             }


}
             

     