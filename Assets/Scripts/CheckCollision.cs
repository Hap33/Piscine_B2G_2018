using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour {

    private void OnCollisionEnter(Collision col)
    {
        switch (col.gameObject.tag){
            case "Object":
                //GameManager.Singleton.RemoveObject(col.gameObject);
                break;
            case "Death":
                GameManager.Singleton.Respawn();
                break;
            case "Exit":
                GameManager.Singleton.LoadNextScene();
                break;
        }
        /*if (col.gameObject.tag == "Object")
        {   
            GameManager.Singleton.RemoveObject(col.gameObject);
        }
        if (col.gameObject.tag == "Death")
        {
            GameManager.Singleton.Rebirth();
        }
        if (col.gameObject.tag == "Exit")
        {
            
        }*/
    }
}