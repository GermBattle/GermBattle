﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {
    public GameObject warning;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void onClick()
    {
        warning.SetActive(true);

    }
    public void quit()
    {
        Application.Quit();
    }
    public void Close()
    {
        warning.SetActive(false);
    }
}
