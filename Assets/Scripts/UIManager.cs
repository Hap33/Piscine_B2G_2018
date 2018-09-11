using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    public GameObject GameManager;
    public GameObject UI_MenuSelecNiveaux;
    public GameObject EventSystemSelec;
    public GameObject EventSystemAccueil;
    public AudioSource Source;
    public AudioClip sonBouton;
    
    void Start () {
		
	}

    public void OnClickJouer()
    {
        Source.PlayOneShot(sonBouton);
        gameObject.SetActive(false);
        EventSystemAccueil.SetActive(false);
        EventSystemSelec.SetActive(true);
        GameManager.SetActive(true);
        UI_MenuSelecNiveaux.SetActive(true);
    }

    public void OnClickQuitter()
    {
        Source.PlayOneShot(sonBouton);
        Application.Quit();
        Debug.Log("Quitter fait");
    }
}
