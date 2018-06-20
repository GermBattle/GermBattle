using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Round : MonoBehaviour {
    public int levelnum;
    public GameObject Cloud;
    public GameObject Background1;
    public GameObject Background2;
    public GameObject Radial1;
    public GameObject Radial2;
    public GameObject Star1;
    public GameObject Star2;
    public GameObject NewSticker;
    public GameObject Lock;
    public GameObject star_3;
    public GameObject star_2;
    public GameObject star_3G;
    public GameObject star_2G;
    public Text leveltext;


    private int isFinsh;
    private int time;
    // Use this for initialization
    void Start () {
        isFinsh = PlayerPrefs.GetInt("isLevel" + levelnum.ToString());
        if (isFinsh == 1)
        {
            time = PlayerPrefs.GetInt("Level" + levelnum.ToString());
            Cloud.SetActive(false);
            Background1.SetActive(true);
            Background2.SetActive(false);
            Star1.SetActive(true);
            Star2.SetActive(false);
            Radial1.SetActive(false);
            Radial2.SetActive(false);
            NewSticker.SetActive(false);
            Lock.SetActive(false);
            leveltext.text = levelnum.ToString();
            
            if (time > 150)
            {
                star_2.SetActive(false);
                star_2G.SetActive(true);
            }
            else if (time > 100)
            {
                star_3.SetActive(false);
                star_3G.SetActive(true);
            }
            else
            {
                star_2G.SetActive(false);
                star_3G.SetActive(false);
            }
        } else
        {
            if (levelnum == 1 || PlayerPrefs.GetInt("isLevel" + (levelnum - 1).ToString()) == 1)
            {
                Cloud.SetActive(false);
                Background1.SetActive(true);
                Background2.SetActive(false);
                Star1.SetActive(false);
                Star2.SetActive(true);
                Radial1.SetActive(true);
                Radial2.SetActive(true);
                NewSticker.SetActive(true);
                Lock.SetActive(false);
                leveltext.text = levelnum.ToString();
            }
            else
            {
                Cloud.SetActive(true);
                Background1.SetActive(false);
                Background2.SetActive(true);
                Star1.SetActive(false);
                Star2.SetActive(false);
                Radial1.SetActive(false);
                Radial2.SetActive(false);
                NewSticker.SetActive(false);
                Lock.SetActive(true);
                leveltext.text = "";
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
