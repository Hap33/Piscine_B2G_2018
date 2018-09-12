using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatforme : MonoBehaviour {

    public Transform landmark_1, landmark_2;
    public float moovingSpeed;

    private int dir;
    private Vector3 dirVector;

    void Start()
    {
        dir = 1;
    }

	void Update () {
        dirVector = new Vector3(landmark_2.position.x - landmark_1.position.x, landmark_2.position.y - landmark_1.position.y, landmark_2.position.z - landmark_1.position.z);

        this.GetComponent<Rigidbody>().velocity = dir * moovingSpeed * dirVector.normalized;
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Landmark")
            dir *= -1;
    }
}
