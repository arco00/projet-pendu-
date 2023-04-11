using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class spawnlettre : MonoBehaviour

{
    public TMP_Text lettre;
    public TestAlphabet Test;


    void Start(){
        lettre.text="a";
        Test = GameObject.FindObjectOfType(typeof(TestAlphabet)) as TestAlphabet;
    }

    void Update() {
     }
     void OnGUI()
    {
        Event e = Event.current;

        if (e.keyCode!=KeyCode.None && e.type==EventType.KeyDown&&Test.Alphabet())
        {
            Debug.Log("Detected key code: " + e.keyCode);
            lettre.text=e.keyCode.ToString();
            
        }
    }
        

     }
     
        
    
    
    

