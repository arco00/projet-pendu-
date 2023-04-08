using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour
{
    public List<GameObject> bodyParts = new List<GameObject>();
    private int a=0;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)){
            Debug.Log ("ca marhe");
           
            bodyParts [a].GetComponent<Rigidbody2D>().simulated=true;
            a=a+1;
        }
    }
}
