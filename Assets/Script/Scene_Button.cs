using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Scene_Button : MonoBehaviour {
    private int Level;
    //public string scene = "<Insert scene name>";
    public float duration = 1.0f;
    public Color color = Color.black;
    // Use this for initialization
    void Start () {
		if (PlayerPrefs.HasKey("isLevel3"))
        {
            Level = 3;
        }
        else if (PlayerPrefs.HasKey("isLevel2"))
        {
            Level = 3;
        }
        else if (PlayerPrefs.HasKey("isLevel1"))
        {
            Level = 2;
        } else
        {
            Level = 1;
        }
	}

    

    private void PerformTransition(string scene)
    {
        Transition.LoadLevel(scene, duration, color);
    }
    // Update is called once per frame
    void Update () {
		
	}
    public void OnClick()
    {
        PerformTransition("GameScene" + Level.ToString());

    }
}
