using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class test : MonoBehaviour
{

 
    private kill killer; 
    public TMP_Text Mots;
    private string mot="a";
    private TestAlphabet Test;
    private AfficherMot Afficher ;
    public AudioSource lettreOkSound;

   void Start()
    {
        mot=Mots.text;
        Test = GameObject.FindObjectOfType(typeof(TestAlphabet)) as TestAlphabet;
        killer = GameObject.FindObjectOfType(typeof(kill)) as kill;
        
    }

  
      void OnGUI()
    {
        //tester si la touche est dans le mot ou non        
        Event e = Event.current;
        
        if(e.keyCode!=KeyCode.None && e.type==EventType.KeyDown && Test.Alphabet()){
    
            if (mot.Contains(e.keyCode.ToString())){
                Debug.Log("mot ok");
                lettreOkSound.Play();
            }

            else{ 
            killer.launch();
            Debug.Log("tester ok"+Mots);
            }
            }
 
    }

 }
        

