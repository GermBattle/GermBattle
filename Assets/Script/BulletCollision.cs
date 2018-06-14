﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BulletCollision : MonoBehaviour {
    public Text score;
    // Use this for initialization
    void Start () {
        //score = GameObject.FindObjectOfType<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTiggerEnter(GameObject cobject)
    {
        Debug.Log("Name: " + cobject.name);
    }
    void OnCollisionEnter(Collision other)
    {
        //进入碰撞器执行的代码
        if (other.gameObject.tag == "Germ")
        {
            Debug.Log("Name: " + other.gameObject.name);
            Debug.Log("Name: " + this.gameObject.name);
           // Destroy(other.gameObject);
            Destroy(this.gameObject);
            //int s = int.Parse(score.text);
            //s++;
           // score.text = s.ToString();
            GameObject blast;
            Debug.Log("Name: " + other.contacts[0].point);

            Vector3 position = other.contacts[0].point;
            blast = Instantiate(GameObject.Find("Eff_Burst_2_loop"), position, Quaternion.identity) as GameObject;
            //ParticleSystem 
            Destroy(blast, 1);
        }
        if (other.gameObject.tag == "Terrain")
        {
            Destroy(this.gameObject);
            GameObject blast;
            Debug.Log("Name: " + other.contacts[0].point);

            Vector3 position = other.contacts[0].point;
            blast = Instantiate(GameObject.Find("Eff_Burst_2_loop"), position, Quaternion.identity) as GameObject;
            //ParticleSystem 
            Destroy(blast, 1);
        }
    }
}
