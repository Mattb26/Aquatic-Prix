using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    public Transform[] targets;
    int currentTarget;
    public float sensivility = 10.0f;
    Vector3 mouseDelta = Vector3.zero;
    Vector3 amount = Vector3.zero;
    Vector3 camPos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        amount.z = 1000;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKey("c")) ;
        {
            currentTarget = currentTarget + 1 >= targets.Length ? 0 : currentTarget + 1;
        }
        mouseDelta.Set(Input.GetAxisRaw("Mouse X"),
                       Input.GetAxisRaw("Mouse Y"),
                       Input.GetAxisRaw("Mouse ScrollWheel"));
        
        amount += mouseDelta * sensivility;
        amount.z = Mathf.Clamp(amount.z, 50,300);
        amount.y = Mathf.Clamp(amount.y, -89, 89);

        camPos =
             Quaternion.AngleAxis(amount.x, Vector3.up)
           * Quaternion.AngleAxis(amount.y, Vector3.right)
           * Vector3.forward;

        camPos *= amount.z * 0.1f;
        camPos += targets[currentTarget].transform.position;
        transform.position = camPos;
        transform.LookAt(targets[currentTarget].transform.position);

    }
}
