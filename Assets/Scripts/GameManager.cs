using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Cameras;

public class GameManager : MonoBehaviour
{

    public static GameManager Singleton;
    public int ObjectTotal;
    public int ObjectsCollected;
    public GameObject ExitDoor;
    public GameObject Ethan;
    public GameObject EthanCam;
    public GameObject EthanSpawn;
    public GameObject[] AllCollectibles;
    public GameObject MenuPause;
    public UIManager UIManager;

    private bool MenuPauseState;

    private void Awake()
    {
        if (Singleton != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Singleton = this;
        }
    }

    private void Start()
    {
        //Respawn();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Start"))
        {
            if (MenuPauseState)
                ExitMenuPause();
            else if (!MenuPauseState)
            {
                MenuPauseState = true;
                Ethan.GetComponent<CheckCollision>().Underwater = false;
                Time.timeScale = 0;
                MenuPause.SetActive(true);
            }
        }
    }

    public void Respawn()
    {
        //Deactive all collectibles
        for (int i = 0; i < AllCollectibles.Length; i++)
        {
            AllCollectibles[i].SetActive(true);
        }

        //Reset Ethan position and velocity, reset the count of collectibles
        Ethan.transform.position = EthanSpawn.transform.position;
        Ethan.transform.localRotation = Quaternion.identity;
        EthanCam.GetComponent<FreeLookCam>().Respawn = true;
        Ethan.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ObjectsCollected = 0;

        //Deactivate the exit door
        ExitDoor.SetActive(false);

        //Reset the UI
        //Debug.Log(ObjectsCollected.ToString() + " | " + ObjectTotal.ToString());
        UIManager.UpdateCount(ObjectsCollected.ToString(), ObjectTotal.ToString());
        UIManager.SetGreenDoor(false);

        ExitMenuPause();
    }

    public void RemoveObject(GameObject objectToRemove)
    {
        objectToRemove.SetActive(false);
        ObjectsCollected += 1;

        //Opens the door once all objects are collected
        if (ObjectsCollected == ObjectTotal)
        {
            ExitDoor.SetActive(true);
            UIManager.SetGreenDoor(true);
        }

        //Reset the UI
        UIManager.UpdateCount(ObjectsCollected.ToString(), ObjectTotal.ToString());
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        this.Respawn();
    }

    public void ExitMenuPause()
    {
        MenuPauseState = false;
        Time.timeScale = 1;
        MenuPause.SetActive(false);
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}

