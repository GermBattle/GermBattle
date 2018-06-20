using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetRecord : MonoBehaviour {
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
    public void Reset() {
        PlayerPrefs.DeleteAll();
    }
    public void Close()
    {
        warning.SetActive(false);
    }

}
