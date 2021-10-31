using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Sound_Controller : MonoBehaviour {

	public GameObject sonidoSeleccionar;
	public GameObject sonidoclick;

	
	void Start () {
		
	}
	
	void Update () {
		
	}

	public void BotonSeleccionar()
    {
		Instantiate(sonidoSeleccionar);
    }

	public void BotonClick()
    {
		Instantiate(sonidoclick);
    }
}
