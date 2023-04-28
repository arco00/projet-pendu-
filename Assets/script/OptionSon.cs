using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;



public class OptionSon : MonoBehaviour
{

    public Slider slider ;
    public AudioMixer Mixer ;
    public string Group;

    public void  changementVol(){
        Mixer.SetFloat(Group,Mathf.Log10(slider.value)*20);
    }
}
