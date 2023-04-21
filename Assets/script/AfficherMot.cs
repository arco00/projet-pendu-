using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class AfficherMot : MonoBehaviour
{
    private int longueur;
    public TMP_Text Mot;
    private string mot;
    public TMP_Text MotAff;
    private string motAff="";
    private string motAffNew;
    private TestAlphabet Test;
    private char lettre;
    public AudioSource victorySound;

    
    
    void Start()
    {
        Test = GameObject.FindObjectOfType(typeof(TestAlphabet)) as TestAlphabet;
        mot=Mot.text;
        longueur=mot.Length;
        // afficher le mot en tant que "-------"
        for (int x = 0; x < longueur; x++){
            motAff=motAff+"-";
        }
        MotAff.text=motAff;    
    }
   void OnGUI()

    { Event e = Event.current;
    if(e.keyCode!=KeyCode.None && e.type==EventType.KeyDown && Test.Alphabet())
        {
           //afficher les caractère corect du mot , garder les caractère incorrect en "-" 
            for (int x = 0; x < longueur; x++){
                   
                    if (e.keyCode.ToString()==mot.Substring(x,1)){
                        motAffNew=motAffNew+e.keyCode.ToString();

                    }
                    else{
                        motAffNew=motAffNew+motAff[x];
                    }
            }
            motAff=motAffNew;
            motAffNew="";
            MotAff.text=motAff;

            if (motAff==mot){
                //test victoire
                Saver save=GameObject.FindObjectOfType(typeof(Saver))as Saver;
                save.mot="";
                victorySound.Play();

                SceneManager.LoadScene("victoire");
            }
         }
            

    }
}


