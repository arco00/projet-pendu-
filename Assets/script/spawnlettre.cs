using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class spawnlettre : MonoBehaviour

{
    public TMP_Text lettre;
    private TestAlphabet Test;
    public string mot;
    
    private int length ;

    


    void Start(){
        DontDestroyOnLoad(gameObject);
        Test = GameObject.FindObjectOfType(typeof(TestAlphabet)) as TestAlphabet;
        mot=lettre.text;
    }

    void Update() {
     }
     public void OnGUI()
    {
        Event e = Event.current;

        //entrer du mot
        if (e.keyCode!=KeyCode.None && e.type==EventType.KeyDown&&Test.Alphabet())
        {
            Debug.Log("Detected key code: " + e.keyCode);
            mot=mot+e.keyCode.ToString();
            lettre.text=mot;
            
        }

        //suppression du dernier caractère si backspace 
        if (e.keyCode==KeyCode.Backspace && e.type==EventType.KeyDown){
            length=mot.Length;
            Debug.Log(mot+mot.Length);
            mot=mot.Remove(length-1);
            lettre.text=mot;

        }
    }
        

     }
     
        
    
    
    

