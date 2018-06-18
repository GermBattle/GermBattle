using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Scene_Button : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnClick()
    {
        Button button = gameObject.GetComponent<Button>() as Button;
        if (button.name == "Rule_Button")
        {
            SceneManager.LoadScene("RuleScene");
        }
        else if (button.name == "Begin_Button")
        {
            SceneManager.LoadScene("GameScene");
        }
        else if (button.name == "Rank_Button")
        {
            SceneManager.LoadScene("RankScene");
        }
        else if (button.name == "Round_Button")
        {
            SceneManager.LoadScene("RoundScene");
        } 
        else if (button.name == "Back_Button")
        {
            SceneManager.LoadScene("MainScene");
        } else
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}
