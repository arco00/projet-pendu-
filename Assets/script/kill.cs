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
     private float timeEnd;
     public float tempsAffichage;
     public AudioSource critSound;
     public AudioSource missSound;
     public AudioSource dgmSound;
     public AudioSource killSound;

     public Saver save ;
    void Start (){
        save=GameObject.FindObjectOfType(typeof(Saver))as Saver;
        b=bodyParts.Count;
        coor1=destroyer.transform.position;
    }

    public void launch(){


         if (a<b){
                 Debug.Log ("ca marhe");
            float random=Random.Range(0,100);

            if (random<=critChance){
                Debug.Log("critsound");
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
                 dgmSound.Play();
                 Debug.Log("dgmsound");
                damage();
            }
            }
        
            
            

    }
    public void damage(){
            
           

            if (a<b-1 && save.victory){
               
                
            //activation de la physique
             bodyParts [a].GetComponent<Rigidbody2D>().simulated=true;
            //particule (limite à 4 car que 5 particules à activer)
            if (a<=4){
                bodyParts[a+1].transform.GetComponentInChildren<ParticleSystem>().Play();
            }
            //impulsion 
            coor2=bodyParts [a].GetComponent<Rigidbody2D>().transform.position;
            bodyParts [a].GetComponent<Rigidbody2D>().AddForce((coor1+coor2)*coefficient);
            a=a+1;
            }

            else {
                // pour activer le dernier morceau (sans le son)
                bodyParts [a].GetComponent<Rigidbody2D>().simulated=true;
                coor2=bodyParts [a].GetComponent<Rigidbody2D>().transform.position;
                 bodyParts [a].GetComponent<Rigidbody2D>().AddForce((coor1+coor2)*coefficient);
                // perdu
                 killSound.Play();
                Debug.Log("finit et jouer killsound");
                save.victory=false;
                timeEnd=0;
            }
            

    }
    void Update(){
        time=time+Time.deltaTime;
        timeEnd=timeEnd+Time.deltaTime;
        if (time>=tempsAffichage && (critique.gameObject.activeSelf || miss.gameObject.activeSelf))
        {
            //enlever le critique et le miss
            critique.gameObject.SetActive(false);
            miss.gameObject.SetActive(false);

        }
        // passer sur al fin
        if (timeEnd>=0.7 && !save.victory){

            SceneManager.LoadScene("Fin");
        }
    }
}


   