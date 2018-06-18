using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    public GameObject Hpbar;
    public GameObject LoseCanvas;
    private float InitialRight;
    private float InitialLeft;
    private float InitialTop;
    private float InitialBottom;
    private float width;
    public float ValueOfHurt;
    // Use this for initialization
    void Start () {
        InitialRight = Hpbar.GetComponent<RectTransform>().offsetMax.x;
        InitialBottom = Hpbar.GetComponent<RectTransform>().offsetMax.y;
        InitialLeft = Hpbar.GetComponent<RectTransform>().offsetMin.x;
        
        width = InitialRight - InitialLeft;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "GermBullet")
        {
            //var left = Hpbar.GetComponent<RectTransform>().offsetMin.x;
            var right = Hpbar.GetComponent<RectTransform>().offsetMax.x;
            if (right -  ValueOfHurt* width >= InitialLeft)
            {
                Hpbar.GetComponent<RectTransform>().offsetMax = new Vector2(right - ValueOfHurt*width, InitialBottom);
            } else
            {
                LoseCanvas.SetActive(true);
            }

            /*
            if (Hpbar.Value > 0)
            {
                Hpbar.SetValue((float)(Hpbar.Value-0.04));
            }
            */
        }
    }
}
