using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAlphabet : MonoBehaviour
{    
    //  mettre dans start  name = GameObject.FindObjectOfType(typeof(TestAlphabet)) as TestAlphabet;


    public KeyCode[] desiredKeys = {KeyCode.A, KeyCode.B, KeyCode.C,KeyCode.D,KeyCode.E,KeyCode.F,KeyCode.G,KeyCode.H,KeyCode.I,KeyCode.J,KeyCode.K,KeyCode.L,
    KeyCode.M,KeyCode.N,KeyCode.O,KeyCode.P,KeyCode.Q,KeyCode.R,KeyCode.S,KeyCode.T,KeyCode.U,KeyCode.V,KeyCode.W,KeyCode.X,KeyCode.Y,KeyCode.Z};
 
 public bool Alphabet()
    {
        //pour tester si la touche est dans l'alphabet
      
     foreach (KeyCode keyToCheck in desiredKeys)
        {
         if (Input.GetKeyDown (keyToCheck))
             return true;
         }
     
     return false;
     
    }
}
