using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Selection_Des_Niveaux : MonoBehaviour {
    
    public AudioSource Source;
    public AudioClip sonBouton;

    public void OnClickButtonChangeScene(string sceneLoadName)
    {
        Source.PlayOneShot(sonBouton);
        SceneManager.LoadScene(sceneLoadName);
    }

    public void OnClickButtonChangeObjects()
    {
        Source.PlayOneShot(sonBouton);
    }

    public void OnClickQuitter()
    {
        Source.PlayOneShot(sonBouton);
        Application.Quit();
        Debug.Log("Quitter fait");
    }
}
