﻿using UnityEngine;
using System.Collections;

public class EscapeQuit : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
}