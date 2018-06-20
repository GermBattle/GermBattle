using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountTime : MonoBehaviour {
    //public float time;
    public GameObject WinCanvas;
    public GameObject Germ;
    public Text finaltime;
    public GameObject star3;
    public GameObject star2;
    private float timer = 1.0f;
    private int totaltime = 0;
    public Text time;
    private int flag = 0;
    public Text timetext;
    public Text timetext2;
    public int Scenenum;
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (Germ.transform.childCount > 0)
            timer -= Time.deltaTime;
        else
        {
            WinCanvas.SetActive(true);
            finaltime.text = totaltime.ToString() + " s";
            if (totaltime > 100) star3.SetActive(false);
            if (totaltime > 150) star2.SetActive(false);
            if (!PlayerPrefs.HasKey("isLevel" + Scenenum.ToString()))
            {
                PlayerPrefs.SetInt("isLevel" + Scenenum.ToString(), 1);
                PlayerPrefs.SetInt("Level" + Scenenum.ToString(), totaltime);
            } else
            {
                if (PlayerPrefs.GetInt("Level" + Scenenum.ToString()) > totaltime) {
                    PlayerPrefs.SetInt("Level" + Scenenum.ToString(), totaltime);
                }
            }
        }
        if (timer <= 0)
        {
            if (flag < 5)
            {
                timetext2.text = "Round " + Scenenum;
                timetext.text = (5 - flag).ToString();
                flag++;
                
            }
            else if (flag == 5)
            {
                Destroy(timetext);
                Destroy(timetext2);
                flag++;
            }
            else
            {
                totaltime += 1;
                string t1 = (totaltime / 600).ToString();
                string t2 = ((totaltime / 60) % 10).ToString();
                string t3 = (totaltime % 60).ToString();
                if (totaltime % 60 < 10)
                {
                    time.text = t1 + t2 + ":0" + t3;
                }
                else
                {
                    time.text = t1 + t2 + ":" + t3;
                }
                
            }
            timer = 1.0f;
        }
    }
}
