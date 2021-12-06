using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class SupervivenciaPuntaje : MonoBehaviour
{
   //public TextMeshProUGUI changingText;
private TextMeshProUGUI TextPro; 
    



     public int oleadanumero;
    // public int b;
    // public int c;
     //public int d;
    void Start() 
    {
     
        TextPro = GetComponent<TextMeshProUGUI>();
        
    }

void Update() {
    
TextPro.text = "Oleada: " + oleadanumero.ToString();
}
 

       
  
}
