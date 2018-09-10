using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour {

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Object")
        {
            GameManager.Singleton.RemoveObject(col.gameObject);
        }
        if (col.gameObject.tag == "Death")
        {
            GameManager.Singleton.Rebirth();
        }
        if (col.gameObject.tag == "Exit")
        {
            Debug.Log("Vous êtes sorti");
        }
    }
}