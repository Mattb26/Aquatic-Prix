using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterInvi : MonoBehaviour
{
public MeshRenderer character;
private Color col;
//[HideInInspector]
private float activationTime;
private bool invisible;


void OnTriggerEnter(Collider other)
{
if (other.tag == "InvisiblePowerUp")
{   
    Destroy(other.gameObject);
    invisible = true;
    activationTime = 0;
    col.b = 2f;
    character.material.color = col;
}
}

void Start()
{
character = GetComponent<MeshRenderer>();
activationTime = 0;
invisible = false;
col = character.material.color;
}

void Update()
{
activationTime += Time.deltaTime;
if(invisible = true && activationTime >= 3)
{
invisible = false;
col.b = 2f;
character.material.color = col;
}
}


}

