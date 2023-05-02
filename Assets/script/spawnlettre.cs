using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class spawnlettre : MonoBehaviour

{
    public TMP_Text lettre;
    private TestAlphabet Test;
    private string mot;   
    private int length ;
    private Saver save;

    


    void Start(){
        Test = GameObject.FindObjectOfType(typeof(TestAlphabet)) as TestAlphabet;
        save = GameObject.FindObjectOfType(typeof(Saver)) as Saver;
        
    }


     public void OnGUI()
    {
        Event e = Event.current;

        //entrer du mot
        
        if (e.keyCode!=KeyCode.None && e.type==EventType.KeyDown&&Test.Alphabet())
        {
            
            mot=mot+e.keyCode.ToString();
            lettre.text=mot;
            save.mot=mot;
            Debug.Log("Detected key code: " + e.keyCode + "le mot est:" + save.mot);
        }

        //suppression du dernier caractère si backspace 

        if (e.keyCode==KeyCode.Backspace && e.type==EventType.KeyDown){
            length=mot.Length;
            Debug.Log(mot+mot.Length);
            mot=mot.Remove(length-1);
            lettre.text=mot;
            save.mot=mot;

        }
    }
        

     }
     
        
    
    
    

