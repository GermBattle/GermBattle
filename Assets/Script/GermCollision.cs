using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GermCollision : MonoBehaviour
{
    //public Text score;
    public GameObject germ;
    // Use this for initialization
    [SerializeField]
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
        //bar = barParent.GetComponentInChildren<ProgressBarPro>();
        hp = 500;
        hpmax = 500;
        //PlayerPrefs.SetInt("currScore", 0);
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
        PlayerPrefs.SetInt("isRecorded", 0);
        //进入碰撞器执行的代码
        if (other.gameObject.tag == "Bullet")
        {
            // Score Calculation



            if (hp > 0)
            {
                hp -= 5;
                //bar.SetValue(hp / hpmax);
                Hpbar.GetComponent<RectTransform>().offsetMax = new Vector2(InitialLeft + hp / hpmax * width, InitialBottom);
            }
            // save score


        }
        if (other.gameObject.tag == "Skill")
        {
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
        }

        if (other.gameObject.tag == "Magical")
        {

            if (hp > 0)
            {
                hp -= 20;
                //bar.SetValue(hp / hpmax);
                Hpbar.GetComponent<RectTransform>().offsetMax = new Vector2(InitialLeft + hp / hpmax * width, InitialBottom);
            }
        }

    }
}
