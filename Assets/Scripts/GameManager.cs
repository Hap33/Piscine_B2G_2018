using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager Singleton;
    public int ObjectTotal;
    public int ObjectIHave;
    public GameObject Exit;
    public GameObject Ethan;
    public GameObject EthanSpawn;
    public GameObject[] ObjectsToActivate;

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

    public void Rebirth()
    {
        for (int i = 0; i < ObjectsToActivate.Length; i++)
        {
            ObjectsToActivate[i].SetActive(true); 
        }
        Ethan.transform.position = EthanSpawn.transform.position;
        Ethan.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ObjectIHave = 0;
        Exit.SetActive(false);
    }

    public void RemoveObject (GameObject whatToDeactivate)
    {
        whatToDeactivate.SetActive(false);
        ObjectIHave += 1;
        if (ObjectIHave == ObjectTotal)
        {
            Exit.SetActive(true);
        }
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
        
