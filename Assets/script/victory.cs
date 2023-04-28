using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class victory : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text Fin;
    private string messageFin;
    void Start()
    {
        
        Saver save=GameObject.FindObjectOfType(typeof(Saver))as Saver;
        if (save.victory){
            messageFin ="VICTOIRE! \n Vous avez trouvez le mot: \n" + save.mot;
            Fin.text=messageFin;

        }
        else{
            messageFin ="PERDU! \n Le mot était : \n" + save.mot;
            Fin.text=messageFin;
        }
        save.victory=true;
        save.mot="";
    }

}
