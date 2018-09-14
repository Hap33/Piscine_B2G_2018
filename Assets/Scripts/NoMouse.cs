using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoMouse : MonoBehaviour {

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Cursor.visible = false;
    }
}
