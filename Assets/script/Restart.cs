using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

   public void Open() {
    SceneManager.LoadScene("menu");
    Saver save=GameObject.FindObjectOfType(typeof(Saver))as Saver;
    save.mot="";
     
   }
}
