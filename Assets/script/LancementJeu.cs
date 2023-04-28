using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LancementJeu : MonoBehaviour
{
   
    public void Open()
    {
        Saver save=GameObject.FindObjectOfType(typeof(Saver))as Saver;
        if(save.optionGame=="Joueurs"){
            SceneManager.LoadScene("entré");
        }
        else if(save.optionGame=="Random"){
            int longueur = Random.Range(3,10);
            char[] alphabet = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M','N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
            for (int x = 0; x < longueur; x++){
                int lettre =Random.Range(0,25);
                save.mot=save.mot+alphabet[lettre];
            }
            Debug.Log("le mot aléatoire est :" +save.mot);
            SceneManager.LoadScene("pendu");
            
        }
        else if(save.optionGame=="List"){
            string[] mots = new string[]{"MANGER","SCORPION","ORNITHORYNQUE","ORQUES","TRAVAILS","COUPS","ROCHER","CAILLOUX","ORDINATEUR",
            "TELEVISION","VOITURE","MAISON","ARBRE","TABLE","CHAISE","LIVRE","STYLO","MONTAGNE","OCEAN","AVION","TRAIN", "BATEAU","SOLEIL","LUNE","ETOILE","PLANETE",
            "GALAXIE","UNIVERS","MARS","JUPITER","SATURNE","PTISITRUC","INCERTAIS","PATATE","MARCHEUR","ROQUETTE","BOISSON","TABLEAUX","HISTORIEN","PIN","MER","SALOPIN","MOI","CHAT",
            "CHIEN", "OISEAU", "POISSON", " LAPIN", "TORTUE", "CHEVAL", "SOURIS", "SERPENT", "POULET","POMME", "BANANE", "ORANGE", "CERISE", "KIWI", "RAISIN", "FRAISE", "ANANAS", 
            "MANGUE", "PAMPLEMOUSSE","VOITURE", "ECOLE", "FEMME", "DANSE", "SAUTER", "REGARDER", "MARCHER", "ATTENDRE", "BOIRE", "LIRE", 
            "CHAUSSURE", "COURIR", "VOYAGER", "CHANGER", "ABSENCE", "COUTURE", "FLEUR", "MUSIQUE", "AVENIR", "IMAGINATION", 
            "NUAGE", "TRAVAILLEUSE", "BIBLIOTHEQUE", "SOEUR", "MARIAGE", "ETOILE", "PARLER", "ENTENDRE", "DECOUVRIR", "MEDECIN", 
            "NAGEUR", "PERE", "BOUTIQUE", "CUISINE", "COIFFURE", "COMMENCER", "FINIR", "GAGNER", "PERDRE", "GRANDIR", "SERIEUX", 
            "CONTENTE", "TRANQUILLE", "SPORTIVE", "HEUREUSE", "JOLIE", "INTENSE", "NERVEUX", "EXCELLENT", "HONNETE", "AMOUREUSE"};
            int val =Random.Range(0,mots.Length);
            save.mot=mots[val];
            Debug.Log("le mot de la liste est :" +save.mot);
            SceneManager.LoadScene("pendu");
            
        }
        
    }

}
