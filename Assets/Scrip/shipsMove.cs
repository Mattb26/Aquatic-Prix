using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipsMove : MonoBehaviour
{

    private CharacterController player;
    public float playerspeed = 5.0f;
    public float playerrotation = 200.0f;
    public float x, y;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        transform.Rotate(x * Time.deltaTime * playerrotation,  0 , 0);
        transform.Translate(0,  0, y * Time.deltaTime * playerspeed);
    }

}