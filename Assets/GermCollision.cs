using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GermCollision : MonoBehaviour {

    // Use this for initialization
    [SerializeField] Transform barParent;
    ProgressBarPro bar;
    public float hp;
    float hpmax;
    void Start () {
        bar = barParent.GetComponentInChildren<ProgressBarPro>();
        hp = 500;
        hpmax = 500;
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    void OnCollisionEnter(Collision other)
    {
        //进入碰撞器执行的代码
        if (other.gameObject.tag == "Bullet")
        {
            Debug.Log("Name: " + other.gameObject.name);
            Debug.Log("Name: " + this.gameObject.name);

            //int s = int.Parse(score.text);
            //s++;
            //score.text = s.ToString();
            GameObject blast;
            Debug.Log("Name: " + other.contacts[0].point);

            Vector3 position = other.contacts[0].point;
            blast = Instantiate(GameObject.Find("Eff_Burst_2_loop"), position, Quaternion.identity) as GameObject;
            //ParticleSystem 
            Destroy(blast, 1);
            if (hp > 0)
            {
                hp -= 5;
                bar.SetValue(hp / hpmax);
            }
        }
    }
}
