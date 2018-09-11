using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager Singleton;
    public int ObjectTotal;
    public int ObjectsCollected;
    public GameObject ExitDoor;
    public GameObject Ethan;
    public GameObject EthanSpawn;
    public GameObject[] AllCollectibles;

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
        ObjectsCollected = 0;
        ExitDoor.SetActive(false);
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
        Ethan.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ObjectsCollected = 0;

        //Deactivate the exit door
        ExitDoor.SetActive(false);
    }

    public void RemoveObject (GameObject objectToRemove)
    {
        objectToRemove.SetActive(false);
        ObjectsCollected += 1;

        //Opens the door once all objects are collected
        if (ObjectsCollected == ObjectTotal)
        {
            ExitDoor.SetActive(true);
        }
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
        
