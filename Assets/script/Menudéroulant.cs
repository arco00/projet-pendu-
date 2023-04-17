using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menudéroulant : MonoBehaviour
{

      public List<GameObject> listoption = new List<GameObject>();
      bool aff = true ;
        public void Open()
    {
        Debug.Log("affichage");
        foreach (GameObject option in listoption) {
        option.gameObject.SetActive(aff);
        }
        aff=!aff;
    }


}
