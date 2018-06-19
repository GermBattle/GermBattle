using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GermCollision : MonoBehaviour
{
    public Text score;
    public GameObject germ;
    // Use this for initialization
    [SerializeField]
    Transform barParent;
    //ProgressBarPro bar;
    public float hp;
    float hpmax;

    //血条相关
    public GameObject Hpbar;
    
    private float InitialRight;
    private float InitialLeft;
    private float InitialTop;
    private float InitialBottom;
    private float width;


    void Start()
    {
        InitialRight = Hpbar.GetComponent<RectTransform>().offsetMax.x;
        InitialBottom = Hpbar.GetComponent<RectTransform>().offsetMax.y;
        InitialLeft = Hpbar.GetComponent<RectTransform>().offsetMin.x;
        width = InitialRight - InitialLeft;
        score = GameObject.FindObjectOfType<Text>();
        //bar = barParent.GetComponentInChildren<ProgressBarPro>();
        hp = 500;
        hpmax = 500;
        PlayerPrefs.SetInt("currScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            Destroy(germ);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        //进入碰撞器执行的代码
        if (other.gameObject.tag == "Bullet")
        {
            // Score Calculation
            int s = int.Parse(score.text);
            s++;
            score.text = s.ToString();



            if (hp > 0)
            {
                hp -= 5;
                //bar.SetValue(hp / hpmax);
                Hpbar.GetComponent<RectTransform>().offsetMax = new Vector2(InitialLeft + hp / hpmax * width, InitialBottom);
            }
            // save score
            PlayerPrefs.SetInt("currScore", s);


        }
        if (other.gameObject.tag == "Skill")
        {
            int s = int.Parse(score.text);
            s += 7;
            score.text = s.ToString();
            //ParticleSystem 
            GameObject blast;
            Vector3 position = other.contacts[0].point;
            blast = Instantiate(GameObject.Find("Eff_Burst_2_loop"), position, Quaternion.identity) as GameObject;
            Destroy(blast, 1);
            if (hp > 0)
            {
                hp -= 35;
                //bar.SetValue(hp / hpmax);
                Hpbar.GetComponent<RectTransform>().offsetMax = new Vector2(InitialLeft + hp / hpmax * width, InitialBottom);
            }
            PlayerPrefs.SetInt("currScore", s);
        }

        if (other.gameObject.tag == "Magical")
        {
            int s = int.Parse(score.text);
            s += 7;
            score.text = s.ToString();

            if (hp > 0)
            {
                hp -= 20;
                //bar.SetValue(hp / hpmax);
                Hpbar.GetComponent<RectTransform>().offsetMax = new Vector2(InitialLeft + hp / hpmax * width, InitialBottom);
            }
            PlayerPrefs.SetInt("currScore", s);
        }

    }
}
