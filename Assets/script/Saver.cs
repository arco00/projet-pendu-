using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saver : MonoBehaviour
{
    public string mot="";
    public string optionGame="Random";

    void Start()
    {
        DontDestroyOnLoad(gameObject);
     
    }


}
