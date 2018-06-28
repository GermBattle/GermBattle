using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GermUp : MonoBehaviour {
	public float showTime; // 出场时间
	public float lastTime; // 持续时间
	//public GameObject germ;
	// Use this for initialization
	void Start () {
		//showTime= 5;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad > showTime && Time.timeSinceLevelLoad < showTime+lastTime) {
			transform.Translate (0, Time.deltaTime * 5, 0);
		}
	}
}
