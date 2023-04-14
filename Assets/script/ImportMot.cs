using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ImportMot : MonoBehaviour
{
    public TMP_Text NewMot ;
    private string newMot;
    
    
    // Start is called before the first frame update

    void Awake()

    {
       
        newMot=NewMot.text;
        spawnlettre spawn=GameObject.FindObjectOfType(typeof(spawnlettre))as spawnlettre;
        newMot=spawn.mot;
        NewMot.text=newMot;
        
    }

   
   
}
