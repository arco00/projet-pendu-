using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class spawnlettre : MonoBehaviour

{
    public TMP_Text lettre;
    
    void Start(){
        lettre.text="a";

    }

    void Update() {

      
     }
     void OnGUI()
    {
        Event e = Event.current;
        if (e.keyCode!=KeyCode.None && e.isKey)
        {
        
            Debug.Log("Detected key code: " + e.keyCode);
            lettre.text=e.keyCode.ToString();
        }
    }
        

     }
     
        
    
    
    

