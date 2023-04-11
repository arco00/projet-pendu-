using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kill : MonoBehaviour
{
    public List<GameObject> bodyParts = new List<GameObject>();
    private int a=0;
    private int b=4;

    void Start (){
        b=bodyParts.Count;
    }

    public void launch(){
         if (a==b){
                Debug.Log("finit");
                SceneManager.LoadScene("Fin");
            }
            
        else{ Debug.Log ("ca marhe");
            bodyParts [a].GetComponent<Rigidbody2D>().simulated=true;
            a=a+1;}

    }
}


   