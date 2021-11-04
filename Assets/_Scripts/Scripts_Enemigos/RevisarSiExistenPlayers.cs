using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevisarSiExistenPlayers : MonoBehaviour
{
    
private IA_Enemigo_Disparo eeee;
private IA_Enemigo_Disparo2 eeee2;

private IA_Enemigo_Disparo3 eeee3;
private IA_Enemigo_Disparo4 eeee4;
    // Start is called before the first frame update
    void Start()
    {
eeee = this.gameObject.GetComponent<IA_Enemigo_Disparo>();
eeee2 = this.gameObject.GetComponent<IA_Enemigo_Disparo2>();
eeee3 = this.gameObject.GetComponent<IA_Enemigo_Disparo3>();
eeee4 = this.gameObject.GetComponent<IA_Enemigo_Disparo4>();

if (GameObject.FindWithTag("Player"))
{
    eeee.enabled = true;
}
else if(!GameObject.FindWithTag("Player"))
{
    eeee.enabled = false;
}


if (GameObject.FindWithTag("Player2"))
{
    eeee2.enabled = true;
}
else if(!GameObject.FindWithTag("Player2"))
{
    eeee2.enabled = false;
}


if (GameObject.FindWithTag("Player3"))
{
    eeee3.enabled = true;
}
else if(!GameObject.FindWithTag("Player3"))
{
    eeee3.enabled = false;
}


if (GameObject.FindWithTag("Player4"))
{
    eeee4.enabled = true;
}
else if(!GameObject.FindWithTag("Player4"))
{
    eeee4.enabled = false;
}


    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
}
