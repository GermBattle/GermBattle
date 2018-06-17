using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllKill : MonoBehaviour {
    public GameObject WinCanvas;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if (this.transform.childCount == 3)
        {
            WinCanvas.SetActive(true);
        } else
        {
            //WinCanvas.SetActive(false);
        }
        
    }
}
