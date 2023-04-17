using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetOptionButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void Open()
    {
        Saver save=GameObject.FindObjectOfType(typeof(Saver))as Saver;
        save.optionGame=gameObject.name; 
        Debug.Log(save.optionGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
