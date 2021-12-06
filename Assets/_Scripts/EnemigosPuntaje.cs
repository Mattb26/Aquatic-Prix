using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class EnemigosPuntaje : MonoBehaviour
{
    // Start is called before the first frame update
   private TextMeshProUGUI TextPro; 
    

     public int enemigosadestruir;
    // public int b;
    // public int c;
     //public int d;
    void Start() 
    {
     
        TextPro = GetComponent<TextMeshProUGUI>();
        
    }

void Update() {
    
TextPro.text = "Enemigos Restantes de la Ola actual: " + enemigosadestruir.ToString();
}
}
