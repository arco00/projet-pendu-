using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kill : MonoBehaviour
{
    public List<GameObject> bodyParts = new List<GameObject>();
    private int a=0;
    private int b=4;
    public GameObject destroyer ;
  
  //coor 1 et 2 et coef sont pour l'impuslion 
    private Vector2 coor1;
    private Vector2 coor2;
    public  float coefficient ;
    void Start (){
        b=bodyParts.Count;
        coor1=destroyer.GetComponent<Rigidbody2D>().transform.position;
    }

    public void launch(){
         if (a==b){
                Debug.Log("finit");
                spawnlettre spawn=GameObject.FindObjectOfType(typeof(spawnlettre))as spawnlettre;
                Destroy(spawn.gameObject);
                SceneManager.LoadScene("Fin");
            }
            
        else{ Debug.Log ("ca marhe");
            //activation de la physique
            bodyParts [a].GetComponent<Rigidbody2D>().simulated=true;
            //impulsion 
            coor2=bodyParts [a].GetComponent<Rigidbody2D>().transform.position;
            bodyParts [a].GetComponent<Rigidbody2D>().AddForce((coor1+coor2)*coefficient);
            a=a+1;}

    }
}


   