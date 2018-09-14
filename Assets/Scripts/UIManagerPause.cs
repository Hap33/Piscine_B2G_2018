using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerPause : MonoBehaviour {

    public AudioSource Source;
    public AudioClip sonBouton;

    private GameManager gm;

    private void Start()
    {
        gm = GameManager.Singleton;
    }

    public void Resume()
    {
        Source.PlayOneShot(sonBouton);
        gm.ExitMenuPause();
    }

    public void Retry()
    {
        Source.PlayOneShot(sonBouton);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        Source.PlayOneShot(sonBouton);
        SceneManager.LoadScene("Main_Menu");
    }

    public void Exit()
    {
        Source.PlayOneShot(sonBouton);
        Debug.Log("Exit");
        Application.Quit();
    }
}
