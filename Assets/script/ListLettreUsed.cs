using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ListLettreUsed : MonoBehaviour

{
  
    private TestAlphabet Test;
     public TMP_Text lettres;
     private string listLettre="";

     public GameObject error ;
     public TMP_Text errorText;
     public bool ActiverPunition;
     private string errorSave ;
     private kill killer; 
     private float time;
     public float tempsAffichage;
 
    // Start is called before the first frame update
    void Start()
    {
    Test = GameObject.FindObjectOfType(typeof(TestAlphabet)) as TestAlphabet;
    errorSave=errorText.text;
     killer = GameObject.FindObjectOfType(typeof(kill)) as kill;
    }

    // Update is called once per frame
    void OnGUI()
    {
        
        Event e = Event.current;
         
        //si on répète une lettre
        if(e.keyCode!=KeyCode.Space&&e.type==EventType.KeyDown &&listLettre.Contains(e.keyCode.ToString())){
            // afficher "erreur"
            errorText.SetText(errorSave+e.keyCode.ToString());
            error.gameObject.SetActive(true);
            time=0;

            //punition de l'erreur
            if (ActiverPunition){
            killer.damage();
            Debug.Log("deja appuyé");}
        }


        if (e.keyCode!=KeyCode.None && e.type==EventType.KeyDown&&Test.Alphabet()
        && !(listLettre.Contains(e.keyCode.ToString())) )
        {
           
            //ajouter la lettre a la liste
            Debug.Log("lettre pas encore appuyé"+listLettre);
            listLettre=listLettre+" "+e.keyCode.ToString();
            lettres.SetText(listLettre);
        }
        
        
    }
    void Update(){
        time=time+Time.deltaTime;
        if (time>=tempsAffichage && error.gameObject.activeSelf)
        {
            //enlever l'erreur
            error.gameObject.SetActive(false);
            errorText.SetText(errorSave);

        }
    }
}
