using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class SimpleMove : MonoBehaviour
{
    public float velocidad = 3.0F;
    public float rotacionVelocidad = 3.0F;
    
    public float duracion;

    void FixedUpdate()
    {
        
        CharacterController controller = GetComponent<CharacterController>();

        // Rotate around y - axis
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotacionVelocidad, 0);

        // Move forward / backward
        Vector3 haciaAdelante = transform.TransformDirection(Vector3.forward);
        float actualVelocidad = velocidad * Input.GetAxis("Vertical");
        controller.SimpleMove(haciaAdelante * actualVelocidad);
    }
    
}