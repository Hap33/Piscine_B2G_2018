﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoMouse : MonoBehaviour {

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    private void FixedUpdate()
    {

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
