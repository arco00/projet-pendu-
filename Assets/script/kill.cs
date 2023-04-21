using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kill : MonoBehaviour
{
    public List<GameObject> bodyParts = new List<GameObject>();
    private int a=0;
    private int b;
    public GameObject destroyer ;
  
  //coor 1 et 2 et coef sont pour l'impuslion 
    private Vector2 coor1;
    private Vector2 coor2;
    public  float coefficient ;
    public int critChance ;
    public int missChance;
     public GameObject critique ;
     public GameObject miss;
     private float time;
     public float tempsAffichage;
     public AudioSource critSound;
     public AudioSource missSound;
     public AudioSource dgmSound;
     public AudioSource killSound;
    void Start (){
        b=bodyParts.Count;
        coor1=destroyer.GetComponent<Rigidbody2D>().transform.position;
    }

    public void launch(){
         if (a==b){
                killSound.Play();
                Debug.Log("finit");
                Saver save=GameObject.FindObjectOfType(typeof(Saver))as Saver;
                save.mot="";
                SceneManager.LoadScene("Fin");
            }
            
        else{ Debug.Log ("ca marhe");
            float random=Random.Range(0,100);

            if (random<=critChance){
                critSound.Play();
              damage();
              damage();
               critique.gameObject.SetActive(true);
                time=0;
            }
            else if (random>=100-missChance){
                missSound.Play();
                miss.gameObject.SetActive(true);
                time=0;
            }
            else {
                
                damage();
            }
            }
            
            

    }
    public void damage(){
             dgmSound.Play();
            //activation de la physique
             bodyParts [a].GetComponent<Rigidbody2D>().simulated=true;
            //impulsion 
            coor2=bodyParts [a].GetComponent<Rigidbody2D>().transform.position;
            bodyParts [a].GetComponent<Rigidbody2D>().AddForce((coor1+coor2)*coefficient);
            a=a+1;

    }
    void Update(){
        time=time+Time.deltaTime;
        if (time>=tempsAffichage && (critique.gameObject.activeSelf || miss.gameObject.activeSelf))
        {
            //enlever le critique
            critique.gameObject.SetActive(false);
            miss.gameObject.SetActive(false);

        }
    }
}


   