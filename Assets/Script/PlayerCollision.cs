using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    public ProgressBarPro Hpbar;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "GermBullet")
        {
            if (Hpbar.Value > 0)
            {
                Hpbar.SetValue((float)(Hpbar.Value-0.04));
            }
        }
    }
}
