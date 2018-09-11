using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour {

    private bool Underwater = false;
    private float MoveY;
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
            /*case "Water":
                Debug.Log("Dans L'eau"); 
                break;*/
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
    private void FixedUpdate()
    {
        MoveY = Input.GetAxis("Vertical");
        if (MoveY > 0 && Underwater == true)
        {
            GetComponent<Rigidbody>().velocity = Camera.main.transform.forward*4f;
        }
        if (MoveY == 0 && Underwater == true)
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Water")
        {
            Underwater = true;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            Physics.gravity = new Vector3(0, 0, 0);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Water")
        {
            Underwater = false;
            Physics.gravity = new Vector3(0, -9.8f, 0);
        }
    }
    
}