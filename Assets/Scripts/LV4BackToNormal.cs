using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LV4BackToNormal : MonoBehaviour {
    public GameObject Ethan;
	void Start () {
        Ethan.GetComponent<CheckCollision>().Underwater = false;
        Physics.gravity = new Vector3(0, -9.8f, 0);
    }
}
