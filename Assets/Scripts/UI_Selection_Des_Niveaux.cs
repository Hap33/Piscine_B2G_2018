using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Selection_Des_Niveaux : MonoBehaviour {

    /*public GameObject UI_MenuSelection;
    public GameObject GameManagerObject;
    public GameObject EventSystemSelec;
    public GameObject EventSystemAccueil;
    public GameObject UI_MenuAccueil;*/
    public AudioSource Source;
    public AudioClip sonBouton;

    public int[] tabMenu;

    public void OnClickButton01()
    {
        Source.PlayOneShot(sonBouton);
        SceneManager.LoadScene("Level_01");
    }

    public void OnClickButton02()
    {
        Source.PlayOneShot(sonBouton);
        SceneManager.LoadScene("Level_02");
    }

    public void OnClickButton03()
    {
        Source.PlayOneShot(sonBouton);
        SceneManager.LoadScene("Level_03");
    }

    public void OnClickButton04()
    {
        Source.PlayOneShot(sonBouton);
        SceneManager.LoadScene("Level_04");
    }

    public void OnClickButton05()
    {
        Source.PlayOneShot(sonBouton);
        SceneManager.LoadScene("Level_05");
    }

    public void OnClickButtonAccueil()
    {
        Source.PlayOneShot(sonBouton);
        /*UI_MenuSelection.SetActive(false);
        GameManagerObject.SetActive(false);
        EventSystemSelec.SetActive(false);
        EventSystemAccueil.SetActive(true);
        UI_MenuAccueil.SetActive(true);*/
    }

    public void OnClickJouer()
    {
        Source.PlayOneShot(sonBouton);
        /*gameObject.SetActive(false);
        EventSystemAccueil.SetActive(false);
        EventSystemSelec.SetActive(true);
        GameManagerObject.SetActive(true);
        UI_MenuSelection.SetActive(true);*/
    }

    public void OnClickQuitter()
    {
        Source.PlayOneShot(sonBouton);
        Application.Quit();
        Debug.Log("Quitter fait");
    }
}
