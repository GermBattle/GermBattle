using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountTime : MonoBehaviour {
    //public float time;
    private float timer = 1.0f;
    private int totaltime;
    public Text time;
    // Use this for initialization
    void Start () {
        totaltime = 0;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            totaltime += 1;
            string t1 = (totaltime / 600).ToString();
            string t2 = ((totaltime / 60)%10).ToString();
            string t3 = (totaltime % 60).ToString();
            if (totaltime % 60 < 10)
            {
                time.text = t1 + t2 + ":0" + t3;
            }
            else
            {
                time.text = t1 + t2 + ":" + t3;
            }
            timer = 1.0f;
        }
    }
}
