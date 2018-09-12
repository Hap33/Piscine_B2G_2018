using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public GameObject canvas;

    private GameManager gm;
    private Text p_Count;
    private Image greenDoor;

    private void Start()
    {
        gm = GameManager.Singleton;
        p_Count = canvas.GetComponentInChildren<Text>();
        greenDoor = canvas.transform.GetChild(1).gameObject.GetComponent<Image>();
    }

    public void UpdateCount()
    {
        p_Count.text = gm.ObjectsCollected.ToString() + "/" + gm.ObjectTotal.ToString(); //Bug NullReferenceException: Object reference not set to an instance of an object - ça marche malgré l'érreur
    }

    public void SetGreenDoor(bool state)
    {
        greenDoor.gameObject.SetActive(state);
    }
}
