using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public GameObject canvas;
    public Text p_Count;
    public Image greenDoor, blackDoor;

    public void UpdateCount(string nbCollected, string nbTotal)
    {
        p_Count.text = nbCollected + "/" + nbTotal;
    }

    public void SetGreenDoor(bool state)
    {
        greenDoor.gameObject.SetActive(state);
        blackDoor.gameObject.SetActive(!state);
    }
}