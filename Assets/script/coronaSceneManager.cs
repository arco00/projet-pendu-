using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class coronaSceneManager : MonoBehaviour
{
    [SerializeField]
    private string scenetoload;

   public void changeScene() {
    SceneManager.LoadScene(scenetoload);
   }
}
