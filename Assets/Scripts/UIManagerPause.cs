using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerPause : MonoBehaviour {

    private GameManager gm;

    private void Start()
    {
        gm = GameManager.Singleton;
    }

    public void Resume()
    {
        gm.ExitMenuPause();
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Exit()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}
