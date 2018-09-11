using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer_Ecran_Fin : MonoBehaviour {

    private float timer = 3.0f;

	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0.0f)
            SceneManager.LoadScene("Menu Selection des niveaux");
	}
}
